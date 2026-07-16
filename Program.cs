using System;
using System.Windows.Forms;

namespace fileDropbox
{
    internal class Program
    {
        [STAThread]
        static void Main()
        {
            fileDropbox applicativo = new fileDropbox();
            applicativo.Run();
        }
    }
}