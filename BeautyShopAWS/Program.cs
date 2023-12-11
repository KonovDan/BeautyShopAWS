using System;
using System.Windows.Forms;
using View;


namespace BeautyShopAWS
{

    internal class Program
    {
        [STAThread]
        static void Main(string[] args)

        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            //Application.Run(new ClientView());
        }
    }
}


