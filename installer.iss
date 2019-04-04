#define AppName "CTS'cape"
#define AppNameFriendly "CTScape"
#define AppEntryPoint "CTScape.exe"
#define AppIconPath ".\CTScape\logo-short.ico"
#define AppURL "https://git.unistra.fr/wguthmann/scl19-t4-d/tags"
#define AppAuthor "Martin Monteil, William Guthmann, Mikail Kocak"
#define AppVersion "1.0.1"
#define BuildSource ".\build\*"

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{4105bbbf-8a9e-40cb-a2ea-059a3eb3973d}
AppName={#AppName}
AppVersion={#AppVersion}
AppPublisher={#AppAuthor}
AppPublisherURL={#AppURL}
AppSupportURL={#AppURL}
AppUpdatesURL={#AppURL}
DefaultDirName={pf}\{#AppName}
DisableProgramGroupPage=yes
LicenseFile=.\LICENSE
OutputDir=.\
OutputBaseFilename=setup-{#AppNameFriendly}-{#AppVersion}-x86_64
SetupIconFile={#AppIconPath}
Compression=lzma
SolidCompression=yes
ChangesEnvironment=yes

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked
Name: "quicklaunchicon"; Description: "{cm:CreateQuickLaunchIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked; OnlyBelowVersion: 0,6.1

[Files]
; NOTE: Don't use "Flags: ignoreversion" on any shared system files
Source: {#BuildSource}; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs

[Icons]
Name: "{commonprograms}\{#AppName}"; Filename: "{app}\{#AppEntryPoint}"
Name: "{userdesktop}\{#AppName}"; Filename: "{app}\{#AppEntryPoint}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#AppEntryPoint}"; Description: "{cm:LaunchProgram,{#AppName}}"; Flags: shellexec postinstall skipifsilent
