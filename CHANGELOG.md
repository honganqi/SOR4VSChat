# Changelog
All notable changes to this project will be documented in
this file.

## 1.2 - 2021/09/14 05:17 GMT+08:00
### Fixed
* fixed the issue where the app crashes when the `!vs` or
`!vschat` commands are used to show the list of enabled commands


## 1.1 - 2021/09/12 20:06 GMT+08:00
### Added
* added textbox for bot response when `!mixitup` is used
* added `response_feedback.html` which allows you to display an
indicator on your overlay by adding it as a browser source in
your streaming software. I have also included some images
(`response_*.png`) required by this file which you may customize
to your liking. A text file, `response_feedback.txt`) is created
by VS Chat on runtime. By default, this fades out in 5 seconds.
You may customize this HTML file and the images to your liking.
### Changed
* transferred some functions into a DLL file to comply with
open-source policies
* changed some words in the way the bot shows the command list
so it won't be blocked by the 500-character limit per message
on Twitch
* reduced width of cooldown textbox and added "(in seconds)"
to the cooldown labels
* some minor UI revisions
### Fixed
* fixed bug where it was still possible for characters whose
checkboxes were not enabled to be summoned by the `!char`
command
* changed "LIFE" cooldown label to "SIZE" in the Character Size
panel
* fixed issue where "Show Command Log" button text stays at
"Hide Command Log" when closing the command log window
* fixed issue where character and move commands do not use the
indicated bot replies
### Removed
* removed an unused function which created a lot of text files
e.g. response_p1_character.txt, response_p1_star.txt, etc.
* removed unnecessary DLL files from the ZIP package
### Known issues
* pseudo-random algorithm for all random commands is not
working e.g. `!life` should only allow a maximum of 3
additions to life then it should go in the other direction
(remove life)


## 1.0 - 2021/09/06 14:56 GMT+08:00
* initial release