## Convert Doc{x,} and more to PDF
This program uses the LibreOffice binary directly since there 
is has not official API for .NET apps.

## Setting it all up
* Linux: install the libreoffice package and make sure the
  /usr/bin/soffice binary exist.
* Windows: Just use it as it is. Don't forget to update LibreOffice once in a while:
  just install the .msi file to the Windows directory.

## Compiling main.cs:
```
mcs main.cs -out:Test.cs
```
