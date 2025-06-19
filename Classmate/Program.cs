using System;
using System.Windows.Forms;

namespace ClassmatesRPG
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles(); // Enables visual styles for Windows Forms
            Application.SetCompatibleTextRenderingDefault(false); // Ensures default rendering
            Application.Run(new Form1()); // Launch the form
        }
    }
}
