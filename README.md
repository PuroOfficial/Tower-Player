## Tower Player
<img src="Tower Player/Properties/Resources/app-icon.png" alt="Tower Player's Logo"></img>


**Credits to: Castle.xyz** *(by Monterey's Coast)*

*this project was made because i was really bored, and uses html for playing.*


## Instructions
If you want to get this to work properly, and play castle's deck please read the instructions!


1. Download the Lastest Release.
2. Get or Share your Deck URL and paste it into the Text Box.
   
> [!note]
>Your Castle Deck URL will be automaticlly replaced with the Deck Id.

3. Wait for the Deck to load.

> [!warning]
> If your deck takes more then 2 minutes to load [refer here](#deck-loading-problems).

**ALL DONE!**


## Small Pros and Cons

Pros|Cons
---- | ----
Higher Performance | No Multi-touch (unless have a touchscreen)
Portable | Audio Tearing (based on your specs)

## Compiling

If you want to compile your project with your changes, Please note that it runs better with Visual Studio 2019.

If you made modifications to your local repository, You can use this information to Build it for Windows as well.


I think you can figure the rest of the compilation yourself If you use Visual Studio everyday.

**If not:**

Open Project or Solution on the Main Page.

Press Play when you are ready to make changes and compile Tower Player.

**Requirements: .NET Framework 4.8 and Visual Studio 2019**

## Troubleshooting


# Launching Problems
If you can't launch the application because it returns an missing .NET Framework, Install the .NET Framework 4.8

**Still haven't trouble?**

If you can't launch the application because of a missing DLL, Your WebView DLL doesn't support your windows or you accidently deleted the Microsoft.Web.WebView2.Core.dll (lol how???)


# Deck Loading Problems
If your deck takes more then 2 minutes.
Your DPI is trying to access something else. (most likely affected people in: Russia)


# Deck Failed to Load (aka: X_X)

Your computer is unreliable to DNS Connection. You can verify by going into CMD and typing **nslookup castle.xyz** if the request times out, You are out of luck.

Check internet connection, Maybe it's weak.

If the face appears when the Deck has loaded successfully, This is a visual bug, You are all good.


Solutions:

> [!caution]
> THESE SOLUTIONS ARE TOO RISKY, PROCEED WITH CAUTION.

> [!warning]
> Maintainer experience these issues as well.

1. Reset your entire PC (only applies if this solution fails: Keep your Data during the PC reset)
2. Contact Microsoft Support
3. Flush your DNS (ipconfig /flushdns)
4. Update your Network Drivers
5. Switch DNS Assignment to either **8.8.8.8, 8.8.4.4 Google** or **1.1.1.1, 1.0.0.1 Cloudflare**
