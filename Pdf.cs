//********************************************************************************************
//Author: Sergey Stoyan
//        sergey.stoyan@gmail.com
//        http://www.cliversoft.com
//********************************************************************************************
using System;
using System.Data.Linq;
using System.Collections.Generic;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Text.RegularExpressions;

namespace Cliver.DisruptivePdf
{
    class Pdf
    {
        //for desktop context
        //static public string OriginPdf = 

        static public string Create(string input_pdf, string password, string output_folder = null)
        {
            if (string.IsNullOrWhiteSpace(input_pdf))
                throw new Exception("Input pdf is not specified.");
            if (string.IsNullOrWhiteSpace(password))
                throw new Exception("Password is not specified.");
            if (string.IsNullOrWhiteSpace(output_folder))
                throw new Exception("Output folder is not specified.");

            if (output_folder == null)
                output_folder = PathRoutines.GetDirFromPath(input_pdf);

            string output_pdf = output_folder + "\\" + PathRoutines.GetFileNameFromPath(input_pdf);
            if (PathRoutines.ArePathsEqual(input_pdf, output_pdf))
                output_pdf = PathRoutines.InsertSuffixBeforeFileExtension(input_pdf, "_out");

            PdfReader.unethicalreading = true;

            PdfReader pr;

            pr = new PdfReader(input_pdf);
            pr.RemoveUsageRights();
            MemoryStream ms = new MemoryStream();
            PdfStamper ps = new PdfStamper(pr, ms);

            ps.FormFlattening = true;

            Rectangle r = pr.GetPageSizeWithRotation(1);
            ps.InsertPage(1, r);
            var pcb = ps.GetOverContent(1);
            add_image(pcb, System.Drawing.Image.FromFile("cover1.jpg"), r);

            ps.InsertPage(2, r);
            pcb = ps.GetOverContent(2);
            add_image(pcb, System.Drawing.Image.FromFile("cover2.jpg"), r);

            ps.Close();
            pr.Close();

            pr = new PdfReader(new MemoryStream(ms.GetBuffer()));
            using (Stream output = new FileStream(output_pdf, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                PdfEncryptor.Encrypt(pr, output, true, password, password, PdfWriter.ALLOW_SCREENREADERS);
            }
            pr.Close();
            return output_pdf;
        }

        static void add_image(PdfContentByte pcb, System.Drawing.Image image, Rectangle r)
        {
            image = ImageRoutines.GetCroppedByColor(image, System.Drawing.Color.Transparent);
            Image i = Image.GetInstance(image, (BaseColor)null);
            //i.ScaleToFit(r);
            var ratio = Math.Min((float)r.Width / image.Width, (float)r.Height / image.Height);
            i.ScalePercent(ratio * 100);
            i.SetAbsolutePosition(r.Left, r.Height - i.ScaledHeight);
            pcb.AddImage(i);
        }
    }
}