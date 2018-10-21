# Doomroulette
Downloads and launches a random [Wad](https://en.wikipedia.org/wiki/Doom_WAD)(map) for Doom2, by using [idGames Archive Public API](https://legacy.doomworld.com/idgames/api/)

## Getting Started

To be able to compile the project you need the following Nugetpackages installed
- Newtonsoft.Json
- System.Data.SQLite.Core
- System.IO.Compression.ZipFile

You also need Doom2 or Freedoom2 which is a free remake of Doom.
You also need a [source port](https://en.wikipedia.org/wiki/Source_port) to run the map on, for example Gzdoom

Freedoom2 can be downloaded here:
https://freedoom.github.io/

Gzdoom can be downloaded here:
https://zdoom.org/

Download Freedoom2 and Gzdoom(or any other source port if you like) and move Freedoom2.wad and Doom2.wad(if you have) to the same folder as Gzdoom are installed at.

First time you run, the application will show the settings dialog which you need to fill in and after that the application needs to cache the data from idGames Archive Public API and save it in the sqlite database.

After this is done, all you need to do is to click Play and Doomroulette will find a random Wad for you and download it and run.
