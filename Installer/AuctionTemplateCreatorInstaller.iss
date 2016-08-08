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
VersionInfoDescription=AuctionTemplateCreator�Z�b�g�A�b�v�v���O����

OutputBaseFilename=AuctionTemplateCreatorInstaller
OutputDir="."
SetupIconFile="..\AuctionTemplateCreator\AuctionTemplateCreator.ico"

[Tasks]
Name: desktopicon; Description: "�f�X�N�g�b�v�ɃV���[�g�J�b�g�A�C�R�����쐬����";

[Files]
Source: "..\AuctionTemplateCreator\bin\Release\AuctionTemplateCreator.exe";    DestDir: "{app}"; Flags: ignoreversion
Source: "..\AuctionTemplateCreator\bin\Release\NexFx.dll";                     DestDir: "{app}"; Flags: ignoreversion

[Icons]
Name: "{group}\AuctionTemplateCreator";         Filename: "{app}\AuctionTemplateCreator.exe"
Name: "{commondesktop}\AuctionTemplateCreator"; Filename: "{app}\AuctionTemplateCreator.exe"; WorkingDir: "{app}"; Tasks: desktopicon

[Languages]
Name: japanese; MessagesFile: compiler:Languages\Japanese.isl

[Run]
Filename: "{app}\AuctionTemplateCreator.exe"; Description: "�A�v���P�[�V�������N������"; Flags: postinstall shellexec skipifsilent