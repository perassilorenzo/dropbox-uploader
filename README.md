# FileCopier

Applicazione Windows sviluppata in C# che permette di copiare rapidamente file tramite interfaccia grafica Windows Forms, con gestione degli errori e sovrascrittura sicura dei file esistenti.

- C#
- .NET 10
- Windows Forms
- GitHub Actions

---

## Funzionalità

- Selezione del file tramite `OpenFileDialog`
- Scelta della cartella di destinazione tramite `FolderBrowserDialog`
- Copia del file con `File.Copy` e sovrascrittura automatica
- Gestione specifica delle eccezioni:
  - permessi insufficienti
  - file aperto da un altro programma
  - errori di I/O
  - errori imprevisti
- Console mantenuta aperta al termine dell'operazione

---

## Come funziona

1. L'utente seleziona il file che vuole copiare tramite una finestra di dialogo Windows.
2. L'applicazione richiede la scelta della cartella di destinazione.
3. Il file viene copiato nella posizione scelta, sostituendo eventuali file con lo stesso nome.
4. Al termine dell'operazione il programma mostra il risultato e rimane aperto in attesa di un input.

---

## Video dimostrativo

[▶ Guarda il video demo](https://github.com/user-attachments/assets/bf127263-e43a-489d-9c85-4e9430effd0f)

---

## Struttura del progetto

```
dropbox-uploader/
├── Program.cs              # Entry point
├── FileCopier.cs           # Classe principale con logica di copia
├── FileCopier.csproj       # Configurazione del progetto
├── demo.mp4                 # Video dimostrativo
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

## Build

```bash
dotnet build
```

## Esecuzione

```bash
dotnet run
```
