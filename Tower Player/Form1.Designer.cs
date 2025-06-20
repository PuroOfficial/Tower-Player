
namespace Tower_Player
{
    partial class castleplayer
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(castleplayer));
            this.windowBar = new System.Windows.Forms.Panel();
            this.windowBar_fullscreenButton = new System.Windows.Forms.Button();
            this.windowBar_minimizeButton = new System.Windows.Forms.Button();
            this.windowBar_maximizeButton = new System.Windows.Forms.Button();
            this.windowBar_closeButton = new System.Windows.Forms.Button();
            this.windowBar_titleLabel = new System.Windows.Forms.Label();
            this.windowBar_appIcon = new System.Windows.Forms.PictureBox();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.recentDeckslistView = new System.Windows.Forms.ListView();
            this.recentDecksLabel = new System.Windows.Forms.Label();
            this.playButton = new System.Windows.Forms.Button();
            this.DeckURLTextBox = new System.Windows.Forms.TextBox();
            this.resizeGrip = new System.Windows.Forms.PictureBox();
            this.loadingCharacterIcon = new System.Windows.Forms.PictureBox();
            this.errorloadingLabel = new System.Windows.Forms.Label();
            this.loadingLabel = new System.Windows.Forms.Label();
            this.deckDescription = new System.Windows.Forms.Label();
            this.rightSide_deckView = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.loadingPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.windowBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.windowBar_appIcon)).BeginInit();
            this.leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resizeGrip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingCharacterIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightSide_deckView)).BeginInit();
            this.rightPanel.SuspendLayout();
            this.loadingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // windowBar
            // 
            this.windowBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.windowBar.Controls.Add(this.windowBar_fullscreenButton);
            this.windowBar.Controls.Add(this.windowBar_minimizeButton);
            this.windowBar.Controls.Add(this.windowBar_maximizeButton);
            this.windowBar.Controls.Add(this.windowBar_closeButton);
            this.windowBar.Controls.Add(this.windowBar_titleLabel);
            this.windowBar.Controls.Add(this.windowBar_appIcon);
            this.windowBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.windowBar.Location = new System.Drawing.Point(0, 0);
            this.windowBar.Margin = new System.Windows.Forms.Padding(0);
            this.windowBar.Name = "windowBar";
            this.windowBar.Size = new System.Drawing.Size(800, 40);
            this.windowBar.TabIndex = 0;
            this.windowBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.windowBar_MouseDown);
            this.windowBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.windowBar_MouseMove);
            this.windowBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.windowBar_MouseUp);
            // 
            // windowBar_fullscreenButton
            // 
            this.windowBar_fullscreenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.windowBar_fullscreenButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.windowBar_fullscreenButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windowBar_fullscreenButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.windowBar_fullscreenButton.Location = new System.Drawing.Point(670, 9);
            this.windowBar_fullscreenButton.Name = "windowBar_fullscreenButton";
            this.windowBar_fullscreenButton.Size = new System.Drawing.Size(25, 25);
            this.windowBar_fullscreenButton.TabIndex = 4;
            this.windowBar_fullscreenButton.Text = "";
            this.windowBar_fullscreenButton.UseVisualStyleBackColor = true;
            this.windowBar_fullscreenButton.Click += new System.EventHandler(this.windowBar_fullscreenButton_Click);
            // 
            // windowBar_minimizeButton
            // 
            this.windowBar_minimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.windowBar_minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.windowBar_minimizeButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windowBar_minimizeButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.windowBar_minimizeButton.Location = new System.Drawing.Point(701, 9);
            this.windowBar_minimizeButton.Name = "windowBar_minimizeButton";
            this.windowBar_minimizeButton.Size = new System.Drawing.Size(25, 25);
            this.windowBar_minimizeButton.TabIndex = 3;
            this.windowBar_minimizeButton.Text = "";
            this.windowBar_minimizeButton.UseVisualStyleBackColor = true;
            this.windowBar_minimizeButton.Click += new System.EventHandler(this.windowBar_minimizeButton_Click);
            // 
            // windowBar_maximizeButton
            // 
            this.windowBar_maximizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.windowBar_maximizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.windowBar_maximizeButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windowBar_maximizeButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.windowBar_maximizeButton.Location = new System.Drawing.Point(732, 9);
            this.windowBar_maximizeButton.Name = "windowBar_maximizeButton";
            this.windowBar_maximizeButton.Size = new System.Drawing.Size(25, 25);
            this.windowBar_maximizeButton.TabIndex = 2;
            this.windowBar_maximizeButton.Text = "";
            this.windowBar_maximizeButton.UseVisualStyleBackColor = true;
            this.windowBar_maximizeButton.Click += new System.EventHandler(this.windowBar_maximizeButton_Click);
            // 
            // windowBar_closeButton
            // 
            this.windowBar_closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.windowBar_closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.windowBar_closeButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windowBar_closeButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.windowBar_closeButton.Location = new System.Drawing.Point(763, 9);
            this.windowBar_closeButton.Name = "windowBar_closeButton";
            this.windowBar_closeButton.Size = new System.Drawing.Size(25, 25);
            this.windowBar_closeButton.TabIndex = 1;
            this.windowBar_closeButton.Text = "";
            this.windowBar_closeButton.UseVisualStyleBackColor = true;
            this.windowBar_closeButton.Click += new System.EventHandler(this.windowBar_closeButton_Click);
            // 
            // windowBar_titleLabel
            // 
            this.windowBar_titleLabel.AutoSize = true;
            this.windowBar_titleLabel.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windowBar_titleLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.windowBar_titleLabel.Location = new System.Drawing.Point(41, 0);
            this.windowBar_titleLabel.Name = "windowBar_titleLabel";
            this.windowBar_titleLabel.Size = new System.Drawing.Size(102, 35);
            this.windowBar_titleLabel.TabIndex = 1;
            this.windowBar_titleLabel.Text = "Tower Player";
            // 
            // windowBar_appIcon
            // 
            this.windowBar_appIcon.Image = global::Tower_Player.Properties.Resources.app_icon1;
            this.windowBar_appIcon.Location = new System.Drawing.Point(3, 3);
            this.windowBar_appIcon.Name = "windowBar_appIcon";
            this.windowBar_appIcon.Size = new System.Drawing.Size(32, 32);
            this.windowBar_appIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.windowBar_appIcon.TabIndex = 0;
            this.windowBar_appIcon.TabStop = false;
            // 
            // leftPanel
            // 
            this.leftPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.leftPanel.Controls.Add(this.label1);
            this.leftPanel.Controls.Add(this.recentDeckslistView);
            this.leftPanel.Controls.Add(this.recentDecksLabel);
            this.leftPanel.Controls.Add(this.playButton);
            this.leftPanel.Controls.Add(this.DeckURLTextBox);
            this.leftPanel.Location = new System.Drawing.Point(0, 40);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(400, 536);
            this.leftPanel.TabIndex = 4;
            // 
            // recentDeckslistView
            // 
            this.recentDeckslistView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.recentDeckslistView.Font = new System.Drawing.Font("Javanese Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recentDeckslistView.HideSelection = false;
            this.recentDeckslistView.Location = new System.Drawing.Point(12, 161);
            this.recentDeckslistView.MultiSelect = false;
            this.recentDeckslistView.Name = "recentDeckslistView";
            this.recentDeckslistView.Size = new System.Drawing.Size(382, 347);
            this.recentDeckslistView.TabIndex = 10;
            this.recentDeckslistView.UseCompatibleStateImageBehavior = false;
            this.recentDeckslistView.View = System.Windows.Forms.View.List;
            this.recentDeckslistView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // recentDecksLabel
            // 
            this.recentDecksLabel.AutoSize = true;
            this.recentDecksLabel.Font = new System.Drawing.Font("Javanese Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recentDecksLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.recentDecksLabel.Location = new System.Drawing.Point(13, 111);
            this.recentDecksLabel.Name = "recentDecksLabel";
            this.recentDecksLabel.Size = new System.Drawing.Size(156, 47);
            this.recentDecksLabel.TabIndex = 9;
            this.recentDecksLabel.Text = "Recent Decks";
            this.recentDecksLabel.Click += new System.EventHandler(this.recentDecksLabel_Click);
            // 
            // playButton
            // 
            this.playButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playButton.Font = new System.Drawing.Font("Javanese Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.Location = new System.Drawing.Point(12, 58);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(382, 46);
            this.playButton.TabIndex = 7;
            this.playButton.Text = "Open Deck";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.leftSide_playButton_Click);
            // 
            // DeckURLTextBox
            // 
            this.DeckURLTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeckURLTextBox.Location = new System.Drawing.Point(12, 32);
            this.DeckURLTextBox.Name = "DeckURLTextBox";
            this.DeckURLTextBox.Size = new System.Drawing.Size(382, 20);
            this.DeckURLTextBox.TabIndex = 6;
            this.DeckURLTextBox.Text = "nDRsXHIL6";
            this.DeckURLTextBox.TextChanged += new System.EventHandler(this.DeckURLTextBox_TextChanged);
            // 
            // resizeGrip
            // 
            this.resizeGrip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.resizeGrip.BackColor = System.Drawing.Color.Transparent;
            this.resizeGrip.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.resizeGrip.Image = global::Tower_Player.Properties.Resources.resize_grip;
            this.resizeGrip.Location = new System.Drawing.Point(784, 582);
            this.resizeGrip.Name = "resizeGrip";
            this.resizeGrip.Size = new System.Drawing.Size(16, 18);
            this.resizeGrip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.resizeGrip.TabIndex = 6;
            this.resizeGrip.TabStop = false;
            this.resizeGrip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.resizeGrip_MouseDown);
            this.resizeGrip.MouseMove += new System.Windows.Forms.MouseEventHandler(this.resizeGrip_MouseMove);
            this.resizeGrip.MouseUp += new System.Windows.Forms.MouseEventHandler(this.resizeGrip_MouseUp);
            // 
            // loadingCharacterIcon
            // 
            this.loadingCharacterIcon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.loadingCharacterIcon.BackColor = System.Drawing.Color.Transparent;
            this.loadingCharacterIcon.Image = global::Tower_Player.Properties.Resources.character_walk;
            this.loadingCharacterIcon.Location = new System.Drawing.Point(160, 90);
            this.loadingCharacterIcon.Name = "loadingCharacterIcon";
            this.loadingCharacterIcon.Size = new System.Drawing.Size(56, 80);
            this.loadingCharacterIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.loadingCharacterIcon.TabIndex = 5;
            this.loadingCharacterIcon.TabStop = false;
            // 
            // errorloadingLabel
            // 
            this.errorloadingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.errorloadingLabel.AutoSize = true;
            this.errorloadingLabel.Font = new System.Drawing.Font("Javanese Text", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorloadingLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.errorloadingLabel.Location = new System.Drawing.Point(140, 243);
            this.errorloadingLabel.Margin = new System.Windows.Forms.Padding(0);
            this.errorloadingLabel.Name = "errorloadingLabel";
            this.errorloadingLabel.Size = new System.Drawing.Size(104, 84);
            this.errorloadingLabel.TabIndex = 4;
            this.errorloadingLabel.Text = "X_X";
            this.errorloadingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.errorloadingLabel.Visible = false;
            // 
            // loadingLabel
            // 
            this.loadingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loadingLabel.Font = new System.Drawing.Font("Javanese Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadingLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.loadingLabel.Location = new System.Drawing.Point(0, 180);
            this.loadingLabel.Name = "loadingLabel";
            this.loadingLabel.Size = new System.Drawing.Size(382, 55);
            this.loadingLabel.TabIndex = 2;
            this.loadingLabel.Text = "Loading Deck...";
            this.loadingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // deckDescription
            // 
            this.deckDescription.BackColor = System.Drawing.Color.Black;
            this.deckDescription.Dock = System.Windows.Forms.DockStyle.Top;
            this.deckDescription.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deckDescription.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.deckDescription.Location = new System.Drawing.Point(0, 0);
            this.deckDescription.MinimumSize = new System.Drawing.Size(0, 40);
            this.deckDescription.Name = "deckDescription";
            this.deckDescription.Size = new System.Drawing.Size(400, 133);
            this.deckDescription.TabIndex = 1;
            this.deckDescription.Text = "Deck";
            // 
            // rightSide_deckView
            // 
            this.rightSide_deckView.AllowExternalDrop = true;
            this.rightSide_deckView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.rightSide_deckView.CreationProperties = null;
            this.rightSide_deckView.DefaultBackgroundColor = System.Drawing.Color.Black;
            this.rightSide_deckView.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.rightSide_deckView.Location = new System.Drawing.Point(6, 150);
            this.rightSide_deckView.Name = "rightSide_deckView";
            this.rightSide_deckView.Size = new System.Drawing.Size(379, 374);
            this.rightSide_deckView.Source = new System.Uri("https://castle.xyz/d/nDRsXHIL6", System.UriKind.Absolute);
            this.rightSide_deckView.TabIndex = 0;
            this.rightSide_deckView.Visible = false;
            this.rightSide_deckView.ZoomFactor = 1D;
            this.rightSide_deckView.NavigationStarting += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs>(this.rightSide_deckView_NavigationStarting);
            this.rightSide_deckView.NavigationCompleted += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs>(this.rightSide_deckView_NavigationCompleted);
            this.rightSide_deckView.ContentLoading += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2ContentLoadingEventArgs>(this.rightSide_deckView_ContentLoading);
            this.rightSide_deckView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.castleplayer_KeyDown);
            // 
            // rightPanel
            // 
            this.rightPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.rightPanel.Controls.Add(this.loadingPanel);
            this.rightPanel.Controls.Add(this.errorloadingLabel);
            this.rightPanel.Controls.Add(this.deckDescription);
            this.rightPanel.Controls.Add(this.rightSide_deckView);
            this.rightPanel.Location = new System.Drawing.Point(400, 40);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(400, 536);
            this.rightPanel.TabIndex = 5;
            // 
            // loadingPanel
            // 
            this.loadingPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loadingPanel.Controls.Add(this.loadingCharacterIcon);
            this.loadingPanel.Controls.Add(this.loadingLabel);
            this.loadingPanel.Location = new System.Drawing.Point(6, 150);
            this.loadingPanel.Name = "loadingPanel";
            this.loadingPanel.Size = new System.Drawing.Size(379, 374);
            this.loadingPanel.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Javanese Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(11, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Put in your Deck Id. (urls converts into ids)";
            // 
            // castleplayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.resizeGrip);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.windowBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "castleplayer";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Tower Player - Castle Deck Player";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.castleplayer_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.castleplayer_KeyDown);
            this.windowBar.ResumeLayout(false);
            this.windowBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.windowBar_appIcon)).EndInit();
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resizeGrip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingCharacterIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightSide_deckView)).EndInit();
            this.rightPanel.ResumeLayout(false);
            this.rightPanel.PerformLayout();
            this.loadingPanel.ResumeLayout(false);
            this.loadingPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel windowBar;
        private System.Windows.Forms.Button windowBar_minimizeButton;
        private System.Windows.Forms.Button windowBar_maximizeButton;
        private System.Windows.Forms.Button windowBar_closeButton;
        private System.Windows.Forms.Label windowBar_titleLabel;
        private System.Windows.Forms.PictureBox windowBar_appIcon;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.TextBox DeckURLTextBox;
        private System.Windows.Forms.Label deckDescription;
        private Microsoft.Web.WebView2.WinForms.WebView2 rightSide_deckView;
        private System.Windows.Forms.Label loadingLabel;
        private System.Windows.Forms.Label errorloadingLabel;
        private System.Windows.Forms.PictureBox loadingCharacterIcon;
        private System.Windows.Forms.PictureBox resizeGrip;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Button windowBar_fullscreenButton;
        private System.Windows.Forms.Panel loadingPanel;
        private System.Windows.Forms.ListView recentDeckslistView;
        private System.Windows.Forms.Label recentDecksLabel;
        private System.Windows.Forms.Label label1;
    }
}

