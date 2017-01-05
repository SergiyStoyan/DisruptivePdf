using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliver.DisruptivePdf
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();

            Password.Text = Settings.Default.Password;
            OutputFolder.Text = Settings.Default.OutputFolder;
            InputPdf.Text = Settings.Default.InputPdf;
        }

        private void selectPdf_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.Title = "Pick a pdf file";
            d.Filter = "Filter pdf files (*.PDF)|*.pdf|All files (*.*)|*.*";
            if (d.ShowDialog(this) != DialogResult.OK || string.IsNullOrWhiteSpace(d.FileName))
                return;
            InputPdf.Text = d.FileName;
        }

        private void Create_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(InputPdf.Text))
                    throw new Exception("Input pdf is not specified.");
                if (string.IsNullOrWhiteSpace(Password.Text))
                    throw new Exception("Password is not specified.");
                if (string.IsNullOrWhiteSpace(OutputFolder.Text))
                    throw new Exception("Output folder is not specified.");

                string f = Pdf.Create(InputPdf.Text, Password.Text, OutputFolder.Text);
                Message.Inform("Completed.");
            }
            catch (Exception ex)
            {
                Cliver.Message.Error(ex);
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Settings.Default.Password = Password.Text;
            Settings.Default.OutputFolder = OutputFolder.Text;
            Settings.Default.InputPdf = InputPdf.Text;
            Settings.Default.Save();
            Close();
        }

        private void selectOutputFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog d = new FolderBrowserDialog();
            d.Description = "Define a folder where to save files";
            if (d.ShowDialog(this) != DialogResult.OK || string.IsNullOrWhiteSpace(d.SelectedPath))
                return;
            OutputFolder.Text = d.SelectedPath;
        }
    }
}