## <u>README</u>

---

C# container for [TaniDvr](https://github.com/arthar360/TaniDVR). TaniDvr is a fantastic piece of software that allows viewing of many legacy cctv dvrs made by a company called Dahua.

Also found at [Tani Sourceforge](https://tanidvr.sourceforge.net/)

---

### <u>Instructions</u>

- Create one config shell file that has the connection details to your dahua dvr

- Add the name of your config shell file to the second shell file. The name for this file is hardcoded into the C# program.

- Example files are included.

---

#### <u>Notes</u>

This program will only run on Linux. Tested on Ubuntu 20.04. Dotnet v7 must be installed. A Tanidvr binary is included. If it does not work then compile your own from tandvr sources and replace the included binary with your own.

---

#### <u>TODO</u>
Add geometry information to the arguments to mplayer in the bash shell config for each connection, so that the videos appear in an odered way.

