
#define MyAppName "AppPlace"
#define MyAppVersion "0.0.1"
#define MyAppExeName "AppPlaces.exe"

[Setup]
AppId={{BF4B33AE-3856-4681-8AE9-3735C97016A2}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;папка, в которую инсталлятор предложит установить программу по умолчанию
DefaultDirName={pf}\{#MyAppName}
; Имя группы в меню "Пуск"
DefaultGroupName={#MyAppName}
;Куда будет записан собранный файл и имя исполняемого файла(скомпилированный исс файл)
OutputDir="output\"
OutputBaseFilename={#MyAppName}
;Файл иконки
SetupIconFile=AppPlaces_icon_100.ico
;парамеры сжатия
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

;запуск после инсталляции
[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

