# File Uploader

Windows C# application for copying files locally or uploading them to Dropbox, with an interactive menu and error handling.

- C#
- .NET 10
- Windows Forms
- Dropbox API
- GitHub Actions

---

## Features

### Local copy

- File selection via `OpenFileDialog`
- Destination folder selection via `FolderBrowserDialog`
- Copy with `File.Copy` and automatic overwrite

### Cloud upload (Dropbox)

- File selection via `OpenFileDialog`
- Upload to Dropbox in the `/Prova/` folder
- Token auto-save in `token.txt`
- If no token is found, the app asks for it and saves it

### Menu

- 1. Local copy
- 2. Cloud upload (Dropbox)
- 3. Change token
- 4. Exit

---

## Video demo (local copy only)

[▶ Watch the video](https://github.com/user-attachments/assets/bf127263-e43a-489d-9c85-4e9430effd0f)

---

## Project structure

```
dropbox-uploader/
├── Program.cs              # Entry point with menu
├── Copier.cs               # Local copy logic
├── Uploader.cs             # Dropbox upload logic
├── FileCopier.csproj       # Project configuration
├── token.txt               # Dropbox token (empty, fill it in)
├── .github/
│   └── workflows/
│       └── dotnet-desktop.yml  # GitHub Actions CI
├── README.md
├── LICENSE
└── .gitignore
```

---

## Requirements

- .NET 10.0 SDK
- Windows (uses Windows Forms)
- Dropbox app with `files.content.write` permission (for cloud upload)

## Token setup

1. Go to [dropbox.com/developers/apps](https://dropbox.com/developers/apps)
2. Create an app **Scoped Access** → **Full Dropbox** or **App Folder**
3. Enable `files.content.write` permission and generate an Access Token
4. Paste it in `token.txt` or use option 3 from the menu

## Build

```bash
dotnet build
```

## Run

```bash
dotnet run
```
