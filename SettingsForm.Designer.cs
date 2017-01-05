namespace Cliver.DisruptivePdf
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.selectPdf = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.InputPdf = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Create = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.OutputFolder = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.selectOutputFolder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selectPdf
            // 
            this.selectPdf.Location = new System.Drawing.Point(418, 25);
            this.selectPdf.Name = "selectPdf";
            this.selectPdf.Size = new System.Drawing.Size(23, 23);
            this.selectPdf.TabIndex = 0;
            this.selectPdf.Text = "...";
            this.selectPdf.UseVisualStyleBackColor = true;
            this.selectPdf.Click += new System.EventHandler(this.selectPdf_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input Pdf:";
            // 
            // InputPdf
            // 
            this.InputPdf.Location = new System.Drawing.Point(24, 25);
            this.InputPdf.Name = "InputPdf";
            this.InputPdf.Size = new System.Drawing.Size(388, 20);
            this.InputPdf.TabIndex = 2;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(24, 113);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(115, 20);
            this.Password.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password:";
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(307, 144);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(64, 23);
            this.Create.TabIndex = 3;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(377, 144);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(64, 23);
            this.Exit.TabIndex = 6;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // OutputFolder
            // 
            this.OutputFolder.Location = new System.Drawing.Point(24, 69);
            this.OutputFolder.Name = "OutputFolder";
            this.OutputFolder.Size = new System.Drawing.Size(388, 20);
            this.OutputFolder.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Output Folder:";
            // 
            // selectOutputFolder
            // 
            this.selectOutputFolder.Location = new System.Drawing.Point(418, 69);
            this.selectOutputFolder.Name = "selectOutputFolder";
            this.selectOutputFolder.Size = new System.Drawing.Size(23, 23);
            this.selectOutputFolder.TabIndex = 7;
            this.selectOutputFolder.Text = "...";
            this.selectOutputFolder.UseVisualStyleBackColor = true;
            this.selectOutputFolder.Click += new System.EventHandler(this.selectOutputFolder_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 181);
            this.Controls.Add(this.OutputFolder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.selectOutputFolder);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.InputPdf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectPdf);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectPdf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InputPdf;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.TextBox OutputFolder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button selectOutputFolder;
    }
}