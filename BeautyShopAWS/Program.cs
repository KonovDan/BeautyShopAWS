using System;
using System.Windows.Forms;
using View;
//using Model;
//using Presenter;
//using Shared;
//using Ninject;


namespace BeautyShopAWS
{
    //private static IKernel ninjectKernel = new StandardKernel(new SimpleConfigModule());
    internal class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            //Model.Model model = ninjectKernel.Get<Model.Model>();

            //Presenter.Presenter presenter = new Presenter.Presenter(formMain, model);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MainForm();
            Application.Run(new Form1());



        }
    }
}


