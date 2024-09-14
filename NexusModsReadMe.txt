[b][size=5]Shortest Trip To Earth - Show Ship Slots[/size][/b] 
 
 
Toggles the visibility of the slots to make it easier to determine which slots to upgrade.
 
The mod does not remove the modules, just hides them temporarily.
 
Pressing the backlash key will toggle the slot visibility.
The hotkey can be changed in the configuration file.
 
The slots can be upgraded when the modules are hidden.
 
[b][size=5]Steam Workshop[/size][/b] 
 
For Steam Users, subscribing to this mod does not install the mod.
Follow [font=Courier New]Installation section[/font] instructions below to install.
 
[b][size=5]Compatibility[/size][/b] 
[list]
[*]Some mods instruct the user to overwrite the game's original files.  This mod may not be compatible with those mods.
[list]
[*]This mod does not affect the original game files.
[/list]
[*]Safe to add and remove from existing saves.
[/list]
 
[b][size=5]Configuration[/size][/b] 
 
The configuration file will be created on the first game run and can be found at [font=Courier New]<Steam Directory>\steamapps\common\Shortest Trip to Earth\BepInEx\config\ShowShipSlots.cfg[/font].  The changes will take effect the next time the game is run.
[font=Courier New]+-------------+-----------+-------------------------------------------------------+
| Name        | Default   | Description                                           |
|=============+===========+=======================================================|
| ShowSlotKey | Backslash | The key to toggle the visibility of the ship's slots. |
+-------------+-----------+-------------------------------------------------------+
[/font]
 
[b][size=5]Support[/size][/b] 
 
If you enjoy my mods and want to buy me a coffee, check out my [url=https://ko-fi.com/nbkredspy71915]Ko-Fi[/url] page.
Thanks!
 
[b][size=5]Installation[/size][/b] 
 
This section covers how to install the BepInEx mod loader and the mod itself.
 
[b][size=4]BepInEx Setup[/size][/b] 
 
If BepInEx has already been installed, skip to the [font=Courier New]Mod Install[/font] section.
[list]
[*]Download BepInEx from [url=https://github.com/BepInEx/BepInEx/releases/download/v5.4.23.2/BepInEx_win_x64_5.4.23.2.zip]https://github.com/BepInEx/BepInEx/releases/download/v5.4.23.2/BepInEx_win_x64_5.4.23.2.zip[/url]
[*]Extract the contents of the BepInEx zip file into the game's directory:
[font=Courier New]<Steam Directory>\steamapps\common\Shortest Trip to Earth[/font]
[*]Run the game.  Once the main menu is shown, exit the game.
[*]If the install was successful, there will now be a [font=Courier New]<Game Dir>/BepInEx/plugins[/font] directory.
[/list]
 
[b][size=3]BepInEx Install Issue.[/size][/b] 
 
If there is not a BepInEx/plugins directory after running the game, make sure BepInEx was extracted to the game's directory and not the .zip file's name.
For example, the game directory should not have a BepInEx_win_x64_5.4.23.2 folder.  In this case, simply move the BepInEx sub directory into the game's folder and run the game again.
 
[b][size=4]Mod Install[/size][/b] 
[list]
[*]Download the ShowShipSlots.zip.
[list]
[*]If on Nexumods.com, download from the Files tab.
[*]Otherwise, download from [url=https://github.com/NBKRedSpy/STTE-ShowShipSlots/releases/]https://github.com/NBKRedSpy/STTE-ShowShipSlots/releases/[/url]
[/list]
[*]Extract the contents of the zip file into the [font=Courier New]<Game Dir>/BepInEx/plugins[/font] folder.
[*]Run the Game.  The mod will now be enabled.
[/list]
 
[b][size=5]Uninstalling[/size][/b] 
 
[b][size=4]Uninstalling This Mod Only[/size][/b] 
 
This method removes this mod, but keeps the BepInEx mod loader and any other mods.
 
Delete the directory [font=Courier New]<Steam Directory>\steamapps\common\Shortest Trip to Earth\BepInEx\plugins\ShowShipSlots[/font].
 
[b][size=4]Uninstall the Mod and BepInEx[/size][/b] 
 
This resets the game to an unmodded state by deleting BepInEx and any BepInEx mods.
 
Delete the following files and folders in the game's directory:
[code]
BepInEx  (<-- Folder)
.doorstop_version
changelog.txt
doorstop_config.ini
winhttp.dll
[/code]
 
[b][size=5]Change Log[/size][/b] 
 
[b][size=4]1.0.0[/size][/b] 
[list]
[*]Release
[/list]
 
[b][size=5]Source Code[/size][/b] 
 
Source code is available on GitHub at [url=https://github.com/NBKRedSpy/STTE-ShowShipSlots]https://github.com/NBKRedSpy/STTE-ShowShipSlots[/url]
