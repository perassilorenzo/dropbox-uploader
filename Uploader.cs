using System;
using System.IO;
using System.Windows.Forms;
using Dropbox.Api;
using Dropbox.Api.Files;

namespace FileCopier
{
    public class Uploader
    {
        public void Run()
        {
            try
            {
                string token = CaricaToken();
                if (string.IsNullOrEmpty(token))
                {
                    Console.WriteLine("Token non presente. Usa il menu per inserirlo.");
                    Console.ReadKey();
                    return;
                }

                OpenFileDialog dialog = new OpenFileDialog();
                if (dialog.ShowDialog() != DialogResult.OK) return;

                using var dbx = new DropboxClient(token);
                using var stream = File.OpenRead(dialog.FileName);

                var uploaded = dbx.Files.UploadAsync(
                    $"/Prova/{Path.GetFileName(dialog.FileName)}",
                    WriteMode.Overwrite.Instance,
                    body: stream
                ).GetAwaiter().GetResult();

                Console.WriteLine($"Caricato: {uploaded.PathDisplay}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Errore: {ex.Message}");
            }
            Console.ReadKey();
        }

        string CaricaToken()
        {
            if (File.Exists("token.txt"))
            {
                string val = File.ReadAllText("token.txt").Trim();
                if (val.Length > 0) return val;
            }
            return null;
        }
    }
}
