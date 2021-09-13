# SOR4 VS Chat

This app lets your viewers enter commands in chat to interact
with your Streets of Rage 4 game in real-time by manipulating
your stars, gravity, health, speed, character size, chosen
character, selected move set, and your lives! (SOR4 only!
Not your actual lives!) This app only works for the Steam
version of the game as far as I know and is known to work only
on the v7 patch of the game (v07-s r13060M) released back
in July 23/24, 2021. Also, this only works on the Twitch
streaming platform. If you have any requests or questions,
please send me a message!

It is advisable to regulate what your viewers can do by
not enabling all of the commands but it is totally up to you.
After setting things up, you can test this app by going to your
channel on Twitch and type commands there even if you're not on
stream.


## Usage
1. **Make an account for your bot on Twitch.** If you prefer,
you can use your own account to respond to chat and skip
this step.
2. **Request an oauth code** Go to [https://twitchapps.com/tmi/](https://twitchapps.com/tmi/)
and log in with your bot (or your account) and get an OAuth
token. An OAuth token is one that allows an app to "log in
immediately" without using username and password; like those
"log in with Google, Facebook, Twitch" buttons. You need this
because the bot needs to be logged in to respond to chat.
3. The OAuth Token should include the "oauth:" prefix.
4. **Input your details.** In this app, input your bot's name
and your channel name in the boxes above. If you are using
your own account, your "Bot username" should be your account's
username.
5. Never show your OAuth token to anybody. This will allow
anybody to control your bot.
6. **Display the command list.** Type in **!vs** and **!vschat**
in chat to see your currently enabled commands!


## Stream Overlay
Included in this package are some files which you can add to
your streaming software (OBS, etc.).

If you want to display the current number of lives on your
overlay for Survival Mode, you may add `response_p1_life.txt` as
text sources in your streaming software. Other text files are
also available if you are playing co-op.

If you want to show visual feedback on what commands are being
used, you may add the `response_feedback.html` file as a browser
source. This comes with images named `response_*.png` which the
HTML file needs. The HTML file reads from a text file named
`response_feedback.txt` which is automatically created by
the VS Chat app on runtime. Feel free to customize the HTML and
image files to your liking.

TL;DR
`response_p1_life.txt` as text source - display lives
`response_feedback.html` as browser source - command feedback


## Donations
[![Buy me A Coffee](http://sidestream.tk/wp-content/uploads/2021/06/white-button-e1624263691285.png "Buy Me A Coffee")](https://buymeacoffee.com/honganqi)

This was created for the Streets of Rage 4 community with
love and care  and is provided without charging anybody.
If this has somehow made you smile or made your day brighter,
please feel free to send me a smile, coffee, pizza, a gamepad,
t-shirt, or anything! Your support means a lot to me as it
will help cover a lot of costs. Thank you!

## Discord
Please feel free to join me on Discord!
[https://discord.gg/5EWphnTpgU](https://discord.gg/5EWphnTpgU)

[![Discord](https://sidestream.tk/wp-content/uploads/2021/09/Discord-Logo-Color.png "Discord")](https://discord.gg/5EWphnTpgU)


## Notes
* The author of this software will not be liable to any
damage to your game installation. If you lose your backup,
you can simply go to Steam and validate your installation to
restore it.
* This app is intended to be used for entertainment purposes
only. If you are not having fun with this, please restore
your files, delete this app, and purge it from your memory.