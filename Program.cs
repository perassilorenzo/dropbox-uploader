using System;

namespace FileCopier
{
    internal class Program
    {
        [STAThread]
        static void Main()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== File Uploader ===");
                Console.WriteLine("1. Copia locale");
                Console.WriteLine("2. Upload Cloud (Dropbox)");
                Console.WriteLine("3. Cambia token");
                Console.WriteLine("4. Esci");
                Console.Write("Scelta: ");
                string scelta = Console.ReadLine();

                switch (scelta)
                {
                    case "1":
                        new Copier().Run();
                        break;
                    case "2":
                        new Uploader().Run();
                        break;
                    case "3":
                        Console.Write("Nuovo token Dropbox: ");
                        string t = Console.ReadLine().Trim();
                        File.WriteAllText("token.txt", t);
                        Console.WriteLine("Token salvato. Premi un tasto...");
                        Console.ReadKey();
                        break;
                    case "4":
                        return;
                }
            }
        }
    }
}
