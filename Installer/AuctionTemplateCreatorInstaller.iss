; -- AuctionTemplateCreatorInstaller.iss --
[Setup]
AppName=AuctionTemplateCreator
AppId=Growup_Consultant/Software/AuctionTemplateCreator
AppPublisher=Growup Consultant
AppCopyright=Growup Consultant
AppVerName=AuctionTemplateCreator 1.0.0.0
AppVersion=1.0.0.0
ArchitecturesInstallIn64BitMode=x64
ArchitecturesAllowed=x64
DefaultDirName={pf}\AuctionTemplateCreator
DefaultGroupName=AuctionTemplateCreator
UninstallDisplayIcon={app}\AuctionTemplateCreator.exe
ShowLanguageDialog=no
VersionInfoVersion=1.0.0.0
VersionInfoDescription=AuctionTemplateCreatorセットアッププログラム

OutputBaseFilename=AuctionTemplateCreatorInstaller
OutputDir="."
SetupIconFile="..\AuctionTemplateCreator\AuctionTemplateCreator.ico"

[Tasks]
Name: desktopicon; Description: "デスクトップにショートカットアイコンを作成する";

[Files]
Source: "..\AuctionTemplateCreator\bin\Release\AuctionTemplateCreator.exe";    DestDir: "{app}"; Flags: ignoreversion
Source: "..\AuctionTemplateCreator\bin\Release\NexFx.dll";                     DestDir: "{app}"; Flags: ignoreversion

[Icons]
Name: "{group}\AuctionTemplateCreator";         Filename: "{app}\AuctionTemplateCreator.exe"
Name: "{commondesktop}\AuctionTemplateCreator"; Filename: "{app}\AuctionTemplateCreator.exe"; WorkingDir: "{app}"; Tasks: desktopicon

[Languages]
Name: japanese; MessagesFile: compiler:Languages\Japanese.isl

[Run]
Filename: "{app}\AuctionTemplateCreator.exe"; Description: "アプリケーションを起動する"; Flags: postinstall shellexec skipifsilent