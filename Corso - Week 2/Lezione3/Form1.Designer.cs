namespace Lezione3
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialogText = new System.Windows.Forms.OpenFileDialog();
            this.buttonCaricaTxt = new System.Windows.Forms.Button();
            this.textBoxFileNameTxt = new System.Windows.Forms.TextBox();
            this.saveFileDialogText = new System.Windows.Forms.SaveFileDialog();
            this.textBoxRegistraFileTxt = new System.Windows.Forms.TextBox();
            this.buttonRegistraTxt = new System.Windows.Forms.Button();
            this.richTextBoxInput = new System.Windows.Forms.RichTextBox();
            this.textBoxOutputExcel = new System.Windows.Forms.TextBox();
            this.buttonRegistraExcel = new System.Windows.Forms.Button();
            this.textBoxInputExcel = new System.Windows.Forms.TextBox();
            this.buttonCaricaExcel = new System.Windows.Forms.Button();
            this.richTextBoxInputExcel = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // openFileDialogText
            // 
            this.openFileDialogText.FileName = "openFileDialog1";
            // 
            // buttonCaricaTxt
            // 
            this.buttonCaricaTxt.Enabled = false;
            this.buttonCaricaTxt.Location = new System.Drawing.Point(51, 64);
            this.buttonCaricaTxt.Name = "buttonCaricaTxt";
            this.buttonCaricaTxt.Size = new System.Drawing.Size(73, 35);
            this.buttonCaricaTxt.TabIndex = 0;
            this.buttonCaricaTxt.Text = "Carica .txt";
            this.buttonCaricaTxt.UseVisualStyleBackColor = true;
            this.buttonCaricaTxt.Click += new System.EventHandler(this.buttonCaricaTxt_Click);
            // 
            // textBoxFileNameTxt
            // 
            this.textBoxFileNameTxt.Location = new System.Drawing.Point(137, 70);
            this.textBoxFileNameTxt.Name = "textBoxFileNameTxt";
            this.textBoxFileNameTxt.Size = new System.Drawing.Size(313, 20);
            this.textBoxFileNameTxt.TabIndex = 1;
            this.textBoxFileNameTxt.Click += new System.EventHandler(this.textBoxFileNameTxt_Click);
            // 
            // textBoxRegistraFileTxt
            // 
            this.textBoxRegistraFileTxt.Location = new System.Drawing.Point(137, 126);
            this.textBoxRegistraFileTxt.Name = "textBoxRegistraFileTxt";
            this.textBoxRegistraFileTxt.Size = new System.Drawing.Size(313, 20);
            this.textBoxRegistraFileTxt.TabIndex = 3;
            this.textBoxRegistraFileTxt.Click += new System.EventHandler(this.textBoxRegistraFileTxt_Click);
            // 
            // buttonRegistraTxt
            // 
            this.buttonRegistraTxt.Enabled = false;
            this.buttonRegistraTxt.Location = new System.Drawing.Point(51, 120);
            this.buttonRegistraTxt.Name = "buttonRegistraTxt";
            this.buttonRegistraTxt.Size = new System.Drawing.Size(73, 35);
            this.buttonRegistraTxt.TabIndex = 2;
            this.buttonRegistraTxt.Text = "Registra .txt";
            this.buttonRegistraTxt.UseVisualStyleBackColor = true;
            this.buttonRegistraTxt.Click += new System.EventHandler(this.buttonRegistraTxt_Click);
            // 
            // richTextBoxInput
            // 
            this.richTextBoxInput.Location = new System.Drawing.Point(467, 41);
            this.richTextBoxInput.Name = "richTextBoxInput";
            this.richTextBoxInput.Size = new System.Drawing.Size(321, 158);
            this.richTextBoxInput.TabIndex = 4;
            this.richTextBoxInput.Text = "";
            // 
            // textBoxOutputExcel
            // 
            this.textBoxOutputExcel.Location = new System.Drawing.Point(137, 309);
            this.textBoxOutputExcel.Name = "textBoxOutputExcel";
            this.textBoxOutputExcel.Size = new System.Drawing.Size(313, 20);
            this.textBoxOutputExcel.TabIndex = 8;
            this.textBoxOutputExcel.Click += new System.EventHandler(this.textBoxOutputExcel_Click);
            // 
            // buttonRegistraExcel
            // 
            this.buttonRegistraExcel.Enabled = false;
            this.buttonRegistraExcel.Location = new System.Drawing.Point(51, 303);
            this.buttonRegistraExcel.Name = "buttonRegistraExcel";
            this.buttonRegistraExcel.Size = new System.Drawing.Size(73, 35);
            this.buttonRegistraExcel.TabIndex = 7;
            this.buttonRegistraExcel.Text = "Registra .txt";
            this.buttonRegistraExcel.UseVisualStyleBackColor = true;
            this.buttonRegistraExcel.Click += new System.EventHandler(this.buttonRegistraExcel_Click);
            // 
            // textBoxInputExcel
            // 
            this.textBoxInputExcel.Location = new System.Drawing.Point(137, 253);
            this.textBoxInputExcel.Name = "textBoxInputExcel";
            this.textBoxInputExcel.Size = new System.Drawing.Size(313, 20);
            this.textBoxInputExcel.TabIndex = 6;
            this.textBoxInputExcel.Click += new System.EventHandler(this.textBoxInputExcel_Click);
            // 
            // buttonCaricaExcel
            // 
            this.buttonCaricaExcel.Enabled = false;
            this.buttonCaricaExcel.Location = new System.Drawing.Point(51, 247);
            this.buttonCaricaExcel.Name = "buttonCaricaExcel";
            this.buttonCaricaExcel.Size = new System.Drawing.Size(73, 35);
            this.buttonCaricaExcel.TabIndex = 5;
            this.buttonCaricaExcel.Text = "Carica .xlsx";
            this.buttonCaricaExcel.UseVisualStyleBackColor = true;
            this.buttonCaricaExcel.Click += new System.EventHandler(this.buttonCaricaExcel_Click);
            // 
            // richTextBoxInputExcel
            // 
            this.richTextBoxInputExcel.Location = new System.Drawing.Point(467, 247);
            this.richTextBoxInputExcel.Name = "richTextBoxInputExcel";
            this.richTextBoxInputExcel.Size = new System.Drawing.Size(321, 158);
            this.richTextBoxInputExcel.TabIndex = 9;
            this.richTextBoxInputExcel.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBoxInputExcel);
            this.Controls.Add(this.textBoxOutputExcel);
            this.Controls.Add(this.buttonRegistraExcel);
            this.Controls.Add(this.textBoxInputExcel);
            this.Controls.Add(this.buttonCaricaExcel);
            this.Controls.Add(this.richTextBoxInput);
            this.Controls.Add(this.textBoxRegistraFileTxt);
            this.Controls.Add(this.buttonRegistraTxt);
            this.Controls.Add(this.textBoxFileNameTxt);
            this.Controls.Add(this.buttonCaricaTxt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialogText;
        private System.Windows.Forms.Button buttonCaricaTxt;
        private System.Windows.Forms.TextBox textBoxFileNameTxt;
        private System.Windows.Forms.SaveFileDialog saveFileDialogText;
        private System.Windows.Forms.TextBox textBoxRegistraFileTxt;
        private System.Windows.Forms.Button buttonRegistraTxt;
        private System.Windows.Forms.RichTextBox richTextBoxInput;
        private System.Windows.Forms.TextBox textBoxOutputExcel;
        private System.Windows.Forms.Button buttonRegistraExcel;
        private System.Windows.Forms.TextBox textBoxInputExcel;
        private System.Windows.Forms.Button buttonCaricaExcel;
        private System.Windows.Forms.RichTextBox richTextBoxInputExcel;
    }
}

