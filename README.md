# File Uploader

Applicazione Windows in C# per copiare file in locale o caricarli su Dropbox, con menu interattivo e gestione degli errori.

- C#
- .NET 10
- Windows Forms
- Dropbox API
- GitHub Actions

---

## Funzionalità

### Copia locale

- Selezione del file tramite `OpenFileDialog`
- Scelta della cartella di destinazione tramite `FolderBrowserDialog`
- Copia con `File.Copy` e sovrascrittura automatica

### Upload Cloud (Dropbox)

- Selezione del file tramite `OpenFileDialog`
- Upload su Dropbox nella cartella `/Prova/`
- Salvataggio automatico del token in `token.txt`
- Se il token non è presente, viene chiesto all'utente e salvato

### Menu

- 1. Copia locale
- 2. Upload Cloud (Dropbox)
- 3. Cambia token
- 4. Esci

---

## Video dimostrativo (solo copia locale)

[▶ Guarda il video](https://github.com/user-attachments/assets/bf127263-e43a-489d-9c85-4e9430effd0f)

---

## Struttura del progetto

```
dropbox-uploader/
├── Program.cs              # Entry point con menu
├── Copier.cs               # Logica di copia locale
├── Uploader.cs             # Logica di upload su Dropbox
├── FileCopier.csproj       # Configurazione del progetto
├── token.txt               # Token Dropbox (vuoto, da compilare)
├── .github/
│   └── workflows/
│       └── dotnet-desktop.yml  # GitHub Actions CI
├── README.md
├── LICENSE
└── .gitignore
```

---

## Requisiti

- .NET 10.0 SDK
- Windows (usa Windows Forms)
- App Dropbox con permessi `files.content.write` (per upload cloud)

## Setup token

1. Vai su [dropbox.com/developers/apps](https://dropbox.com/developers/apps)
2. Crea un'app **Scoped Access** → **Full Dropbox** o **App Folder**
3. Spunta `files.content.write` nei permessi e genera l'Access Token
4. Inseriscilo in `token.txt` oppure usa l'opzione 3 del menu

## Build

```bash
dotnet build
```

## Esecuzione

```bash
dotnet run
```
