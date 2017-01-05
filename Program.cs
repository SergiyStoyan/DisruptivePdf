//********************************************************************************************
//Author: Sergey Stoyan
//        sergey.stoyan@gmail.com
//        http://www.cliversoft.com
//********************************************************************************************
using System;
using System.Diagnostics;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace Cliver.DisruptivePdf
{
    class Program
    {
        [STAThread]
        static void Main()
        {
            try
            {
                //string[] ps = Environment.GetCommandLineArgs();
                //if (ps.Length < 6)
                //{
                //    Console.WriteLine("USAGE: #<application.exe> <input pdf> <password>");
                //    Console.WriteLine("Press any key to exit...");
                //    Console.ReadKey();
                //    return;
                //}

                SettingsForm sf = new SettingsForm();
                Application.Run(sf);

                //string f = Pdf.Create(Directory.GetCurrentDirectory() + "\\out.pdf", fs2v, Image.FromFile(ps[1]), Image.FromFile(ps[2]), Image.FromFile(ps[3]), ps[4], ps[5]);
                //Console.WriteLine("Created pdf: " + f);
                //Process.Start(f);
            }
            catch (Exception e)
            {
                Cliver.Message.Error(e);

                //Console.WriteLine("ERROR: " + e.Message);
                //for (; e.InnerException != null; e = e.InnerException)
                //    Console.WriteLine("<= " + e.Message);
                //Console.WriteLine("Press any key to exit...");
                //Console.ReadKey();
                //return;
            }
        }
    }
}