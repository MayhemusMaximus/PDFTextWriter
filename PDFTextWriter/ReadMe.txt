[RM] 3/9/2015
1. Changed feedback text boxes to read only.
2. Changed folder browser to msoFileDialogFolderPicker for ease-of-use.
3. Updated publish to Click-Once.
4. Added simple Readme.
5. Added jitdebugging to app.config.

[RM] 3/10/2015
1. Changed schema from DotNetConfig to DotNetConfig35
2. Added datagridview to be populated by all pdf files in selected directory.
3. Removed Heat Textbox.
4. Implemented the ability for the user to adjust several files at once in datagridview.
5. Changed implementation of the Origin browse so that it gets the files in the selected directory.
6. Updated implementation of Form Title Version Info, thus stopping the null reference exception on start up.
7. Added validation to check for PDF's in the selected origin.
8. Added validation on "Write Heat" click to ensure a directory has been provided for the origin.
9. Added validation on "Write Heat" click to ensure a directory has been provided for the destination.
10. Updated "Write Heat" to make the new file name include the heat number instead of "with heat".
11. Updated form load to unenable the "Write Heat" button - this will only be enabled when both directories have valid values.