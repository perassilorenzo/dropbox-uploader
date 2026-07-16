using System;
using System.IO;
using System.Windows.Forms;

namespace fileDropbox
{
    public class fileDropbox
    {
        public void Run()
        {
            try
            {
                OpenFileDialog fileDialog = new OpenFileDialog();
                FolderBrowserDialog folderDialog = new FolderBrowserDialog();

                if (fileDialog.ShowDialog() != DialogResult.OK || folderDialog.ShowDialog() != DialogResult.OK) return;

                string fileOrigine = fileDialog.FileName;
                string cartellaDestinazione = folderDialog.SelectedPath;

                string destinazione = Path.Combine(cartellaDestinazione, Path.GetFileName(fileOrigine));

                File.Copy(fileOrigine, destinazione, true);

                Console.WriteLine("File copiato correttamente:");
                Console.WriteLine(destinazione);
            }
            catch (Exception)
            {
                Console.WriteLine("ERRORE");
                return;
            }
        }
    }
}