using Microsoft.Web.WebView2.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Tower_Player
{
    public partial class castleplayer : Form
    {
        public class NextData
        {
            public Props props { get; set; }
        }

        public class Props
        {
            public PageProps pageProps { get; set; }
        }

        public class PageProps
        {
            public string id { get; set; }
            public Deck deck { get; set; }
        }

        public class Deck
        {
            public string id { get; set; }
            public string caption { get; set; }
            public List<Reaction> reactions { get; set; }
            public List<Variable> variables { get; set; }
            public InitialCard initialCard { get; set; }
            public Creator creator { get; set; }
        }

        public class Reaction
        {
            public string reactionId { get; set; }
            public int count { get; set; }
        }

        public class Variable
        {
            public string id { get; set; }
            public string name { get; set; }
            public string lifetime { get; set; }
            public int initialValue { get; set; }
            public int value { get; set; }
        }

        public class InitialCard
        {
            public string id { get; set; }
        }

        public class Creator
        {
            public string userId { get; set; }
            public string username { get; set; }
            public Photo photo { get; set; }
        }

        public class Photo
        {
            public string url { get; set; }
        }




        private Point _mouseLoc;

        bool resizeMov;
        int Mx;
        int My;
        int Sw;
        int Sh;

        bool isFullscreen;

        public castleplayer()
        {
            InitializeComponent();
        }


        // Window Bar Buttons
        private void windowBar_closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void windowBar_maximizeButton_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.windowBar_maximizeButton.Text = "";
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                this.windowBar_maximizeButton.Text = "";
            }
        }

        private void windowBar_minimizeButton_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void windowBar_fullscreenButton_Click(object sender, EventArgs e)
        {
            toggleFullscreen();
        }
        // Window Bar Buttons


        private void leftSide_playButton_Click(object sender, EventArgs e)
        {
            string urlString = $"https://castle.xyz/d/{this.DeckURLTextBox.Text}";
            Uri uri = new Uri(urlString);
            rightSide_deckView.Source = uri;
        }

        private void DeckURLTextBox_TextChanged(object sender, EventArgs e)
        {
            if (DeckURLTextBox.Text.StartsWith("https://castle.xyz/d/") == true || DeckURLTextBox.Text.StartsWith("https://castle.xyz/") == true || DeckURLTextBox.Text.StartsWith("https://") == true)
            {
                DeckURLTextBox.Text = DeckURLTextBox.Text.Replace("https://castle.xyz/d/", "");
                DeckURLTextBox.Text = DeckURLTextBox.Text.Replace("https://castle.xyz/", "");
                DeckURLTextBox.Text = DeckURLTextBox.Text.Replace("https://", "");
            }
        }

        private void rightSide_deckView_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            if (e.IsSuccess == true)
            {
                _ = HandleNavigationCompletedAsync();
            }

            if (e.IsSuccess == false)
            {
                loadingPanel.Visible = false;

                errorloadingLabel.Visible = true;
            }
        }

        private async Task HandleNavigationCompletedAsync()
        {
                await rightSide_deckView.CoreWebView2.ExecuteScriptAsync(@"
(function() {
    const root = document.getElementById('__next');
    if (!root) return 'Element #__next not found';

    // Loop through all descendants with class or ID attributes
    const elements = root.querySelectorAll('[class], [id]');

    elements.forEach(el => {
        const classes = Array.from(el.classList || []);
        const id = el.id || '';

        // Check for deck_appBanner__XXXXX class
        const hasBannerClass = classes.some(cls => /^deck_appBanner__\w{5}$/.test(cls));

        const hasHeaderClass = classes.some(cls => /^deck_header__\w{5}$/.test(cls));

        // Check for deck_bottom__XXXXX ID
        const hasBottomId = /^deck_bottom__\w{5}$/.test(id);

        if (hasBannerClass || hasHeaderClass || hasBottomId) {
            el.remove();
        }
    });

    return 'deck_appBanner__XXXXX classes and deck_bottom__XXXXX ids removed.';
})();
");

            // Json Reading for Nerds

            string json = await rightSide_deckView.CoreWebView2.ExecuteScriptAsync(
                "document.getElementById('__NEXT_DATA__').textContent");

            json = json.Trim('"').Replace("\\\"", "\"").Replace("\\\\", "\\");

            // Parse the JSON
            var jObject = JObject.Parse(json);

            string caption = jObject["props"]?["pageProps"]?["deck"]?["caption"]?.ToString();
            string username = jObject["props"]?["pageProps"]?["deck"]?["creator"]?["username"]?.ToString();
            string deckId = jObject["props"]?["pageProps"]?["deck"]?["deckId"]?.ToString();
            int fireReactions = jObject["props"]?["pageProps"]?["deck"]?["reactions"]?[0]?["count"]?.ToObject<int>() ?? 0;

            string output = $"{caption}\n" +
                           $"Creator: @{username}\n" +
                           $"🔥 Reactions: {fireReactions}";

            ListViewItem newrecentdeck = this.recentDeckslistView.Items.Add($"{caption} - {username}");
            newrecentdeck.ToolTipText = $"Deck Id: {deckId}";
            newrecentdeck.Tag = $"{deckId}";

            recentDeckslistView.Sorting = SortOrder.Descending;

            // Update the UI (invoke if needed for thread safety)
            if (deckDescription.InvokeRequired)
            {
                deckDescription.Invoke(new Action(() => deckDescription.Text = output));
            }
            else
            {
                deckDescription.Text = output;
            }

            loadingPanel.Visible = false;

            rightSide_deckView.Visible = true;
        }

        private void rightSide_deckView_NavigationStarting(object sender, CoreWebView2NavigationStartingEventArgs e)
        {
            rightSide_deckView.Visible = false;

            loadingPanel.Visible = true;
        }

        private void rightSide_deckView_ContentLoading(object sender, CoreWebView2ContentLoadingEventArgs e)
        {
            
        }


        private void toggleFullscreen()
        {
            if (isFullscreen == true)
            {
                this.WindowState = FormWindowState.Normal;
                this.TopMost = false;
                this.windowBar.Visible = true;
                this.deckDescription.Visible = true;
                this.rightSide_deckView.ZoomFactor = 1;
                this.rightSide_deckView.Dock = DockStyle.None;
                this.rightPanel.Dock = DockStyle.None;
                this.rightPanel.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom);
                isFullscreen = false;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                this.TopMost = true;
                this.windowBar.Visible = false;
                this.deckDescription.Visible = false;
                this.rightSide_deckView.ZoomFactor = 1.5;
                this.rightSide_deckView.Dock = DockStyle.Fill;
                this.rightPanel.Dock = DockStyle.Fill;
                isFullscreen = true;
            }
        }

        private void windowBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            _mouseLoc = e.Location;
        }

        private void windowBar_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void windowBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.Location.X - _mouseLoc.X;
                int dy = e.Location.Y - _mouseLoc.Y;
                this.Location = new Point(this.Location.X + dx, this.Location.Y + dy);
            }
        }

        private void resizeGrip_MouseDown(object sender, MouseEventArgs e)
        {
            resizeMov = true;
            this.Location = new Point(this.Location.X, this.Location.Y);
            My = MousePosition.Y;
            Mx = MousePosition.X;
            Sw = this.Width;
            Sh = this.Height;
        }

        private void resizeGrip_MouseUp(object sender, MouseEventArgs e)
        {
            resizeMov = false;
        }

        private void resizeGrip_MouseMove(object sender, MouseEventArgs e)
        {
            if (resizeMov == true)
            {
                this.Width = MousePosition.X - Mx + Sw;
                this.Height = MousePosition.Y - My + Sh;
            }
        }

        private void castleplayer_Paint(object sender, PaintEventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                resizeGrip.Visible = false;
            }
            if (this.WindowState == FormWindowState.Normal)
            {
                resizeGrip.Visible = true;
            }
        }

        private void castleplayer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F11 || e.KeyData == (Keys.Control | Keys.F))
            {
                toggleFullscreen();
            }
            if (e.KeyData == Keys.Escape && isFullscreen == true)
            {
                toggleFullscreen();
            }
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo hitTest = recentDeckslistView.HitTest(e.Location);

            if (hitTest.Item != null)
            {
                string deckId = (string)hitTest.Item.Tag;
                if (!string.IsNullOrEmpty(deckId))
                {
                    rightSide_deckView.CoreWebView2.Navigate($"https://castle.xyz/d/{deckId}");
                }
            }
        }

        private void recentDecksLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
