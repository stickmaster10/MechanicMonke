# MechanicMonke Beta ![GitHub Downloads (all assets, all releases)](https://img.shields.io/github/downloads/binguszingus/MechanicMonke/total)
This is a successor to [MonkeModManager](https://github.com/DeadlyKitten/MonkeModManager) that:
- Remains fully compatable with all MMM mods (including MakeRelease.ps1)
- Has it's own catalog and filtering system that includes the original MMM mod list
- Can detect what mods are installed based off of the filename or certain keywords in the naming scheme and update them accordingly

## TOC
- [Quick Links](#quick-links)
- [Build](#build)
- [FAQ](#faq)

![image](https://github.com/user-attachments/assets/702b1b9b-06bc-4732-af40-6b2fac4f6c08)

## Quick Links
- Gorilla Tag Modding Group: https://discord.gg/monkemod
- Mod Catalog (.json): https://github.com/binguszingus/MMDictionary

## Build
### MechanicMonke
Get a release of VS2022 and ensure it has the .NET with C# package installed.
From there, cd to your MechanicMonke source folder, and run:
```
dotnet build
```

### Installer
Make sure you have Inno Setup installed.
Open ``MechanicMonke.iss`` and compile it ``CTRL + F9``.

## FAQ
### I want my mod added / removed
For additions, send a PR to [MMDictionary](https://github.com/binguszingus/MMDictionary), and most of the time, it'll get accepted.
For removals, send a PR to [MMDictionary](https://github.com/binguszingus/MMDictionary), or DM me on Discord ``bingus.bingus.bingus`` and I'll remove it personally.

### Why is there a ``setup.exe``?
It is there for convenience. I am also providing a plain .exe build incase you may think it's sketchy.

### Is this a rat?
You can read the source at any time. No.
