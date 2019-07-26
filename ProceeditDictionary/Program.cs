using System;
using System.Windows.Forms;
using ProceeditDictionary.screens.Main;

namespace ProceeditDictionary
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new dyWords());
        }
    }
}
