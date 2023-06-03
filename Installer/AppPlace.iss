
#define MyAppName "AppPlace"
#define MyAppVersion "0.0.1"
#define MyAppExeName "AppPlaces.exe"

[Setup]
AppId={{BF4B33AE-3856-4681-8AE9-3735C97016A2}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;�����, � ������� ����������� ��������� ���������� ��������� �� ���������
DefaultDirName={pf}\{#MyAppName}
; ��� ������ � ���� "����"
DefaultGroupName={#MyAppName}
;���� ����� ������� ��������� ���� � ��� ������������ �����(���������������� ��� ����)
OutputDir="output\"
OutputBaseFilename={#MyAppName}
;���� ������
SetupIconFile=AppPlaces_icon_100.ico
;�������� ������
Compression=lzma
SolidCompression=yes

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"
Name: "russian"; MessagesFile: "compiler:Languages\Russian.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "..\AppPlaces\AppPlaces\bin\Debug\{#MyAppExeName}"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\AppPlaces\AppPlaces\bin\Debug\*.dll"; DestDir: "{app}"; Flags: ignoreversion
[Icons]
Name: "{autoprograms}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

;������ ����� �����������
[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

