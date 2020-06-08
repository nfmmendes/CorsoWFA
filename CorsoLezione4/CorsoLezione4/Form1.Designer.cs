namespace CorsoLezione4
{
    partial class FormProccessi
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
            this.openFileDialogInput = new System.Windows.Forms.OpenFileDialog();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageEsempio1 = new System.Windows.Forms.TabPage();
            this.richTextBoxMatrix = new System.Windows.Forms.RichTextBox();
            this.labelDistanzaMedia = new System.Windows.Forms.Label();
            this.labelNumeroPunti = new System.Windows.Forms.Label();
            this.buttonOttimizza = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCaricaInput1 = new System.Windows.Forms.Button();
            this.textBoxPercorsoInput1 = new System.Windows.Forms.TextBox();
            this.tabPageEsempio2 = new System.Windows.Forms.TabPage();
            this.buttonEsempio2 = new System.Windows.Forms.Button();
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.tabControlMain.SuspendLayout();
            this.tabPageEsempio1.SuspendLayout();
            this.tabPageEsempio2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageEsempio1);
            this.tabControlMain.Controls.Add(this.tabPageEsempio2);
            this.tabControlMain.Location = new System.Drawing.Point(36, 50);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(741, 451);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageEsempio1
            // 
            this.tabPageEsempio1.Controls.Add(this.richTextBoxMatrix);
            this.tabPageEsempio1.Controls.Add(this.labelDistanzaMedia);
            this.tabPageEsempio1.Controls.Add(this.labelNumeroPunti);
            this.tabPageEsempio1.Controls.Add(this.buttonOttimizza);
            this.tabPageEsempio1.Controls.Add(this.label3);
            this.tabPageEsempio1.Controls.Add(this.label2);
            this.tabPageEsempio1.Controls.Add(this.label1);
            this.tabPageEsempio1.Controls.Add(this.buttonCaricaInput1);
            this.tabPageEsempio1.Controls.Add(this.textBoxPercorsoInput1);
            this.tabPageEsempio1.Location = new System.Drawing.Point(4, 22);
            this.tabPageEsempio1.Name = "tabPageEsempio1";
            this.tabPageEsempio1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEsempio1.Size = new System.Drawing.Size(733, 425);
            this.tabPageEsempio1.TabIndex = 0;
            this.tabPageEsempio1.Text = "Esempio 1";
            this.tabPageEsempio1.UseVisualStyleBackColor = true;
            // 
            // richTextBoxMatrix
            // 
            this.richTextBoxMatrix.Location = new System.Drawing.Point(266, 94);
            this.richTextBoxMatrix.Name = "richTextBoxMatrix";
            this.richTextBoxMatrix.Size = new System.Drawing.Size(447, 273);
            this.richTextBoxMatrix.TabIndex = 8;
            this.richTextBoxMatrix.Text = "";
            this.richTextBoxMatrix.WordWrap = false;
            // 
            // labelDistanzaMedia
            // 
            this.labelDistanzaMedia.AutoSize = true;
            this.labelDistanzaMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelDistanzaMedia.Location = new System.Drawing.Point(178, 196);
            this.labelDistanzaMedia.Name = "labelDistanzaMedia";
            this.labelDistanzaMedia.Size = new System.Drawing.Size(0, 20);
            this.labelDistanzaMedia.TabIndex = 7;
            // 
            // labelNumeroPunti
            // 
            this.labelNumeroPunti.AutoSize = true;
            this.labelNumeroPunti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelNumeroPunti.Location = new System.Drawing.Point(178, 155);
            this.labelNumeroPunti.Name = "labelNumeroPunti";
            this.labelNumeroPunti.Size = new System.Drawing.Size(0, 20);
            this.labelNumeroPunti.TabIndex = 6;
            // 
            // buttonOttimizza
            // 
            this.buttonOttimizza.Enabled = false;
            this.buttonOttimizza.Location = new System.Drawing.Point(347, 390);
            this.buttonOttimizza.Name = "buttonOttimizza";
            this.buttonOttimizza.Size = new System.Drawing.Size(91, 29);
            this.buttonOttimizza.TabIndex = 5;
            this.buttonOttimizza.Text = "Ottimizza";
            this.buttonOttimizza.UseVisualStyleBackColor = true;
            this.buttonOttimizza.Click += new System.EventHandler(this.buttonOttimizza_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(24, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Distanza media :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(24, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numero di punti :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(20, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dati input";
            // 
            // buttonCaricaInput1
            // 
            this.buttonCaricaInput1.Enabled = false;
            this.buttonCaricaInput1.Location = new System.Drawing.Point(347, 26);
            this.buttonCaricaInput1.Name = "buttonCaricaInput1";
            this.buttonCaricaInput1.Size = new System.Drawing.Size(91, 29);
            this.buttonCaricaInput1.TabIndex = 1;
            this.buttonCaricaInput1.Text = "Carica Input";
            this.buttonCaricaInput1.UseVisualStyleBackColor = true;
            this.buttonCaricaInput1.Click += new System.EventHandler(this.buttonCaricaInput1_Click);
            // 
            // textBoxPercorsoInput1
            // 
            this.textBoxPercorsoInput1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.textBoxPercorsoInput1.Location = new System.Drawing.Point(27, 27);
            this.textBoxPercorsoInput1.Name = "textBoxPercorsoInput1";
            this.textBoxPercorsoInput1.Size = new System.Drawing.Size(296, 29);
            this.textBoxPercorsoInput1.TabIndex = 0;
            this.textBoxPercorsoInput1.Click += new System.EventHandler(this.textBoxPercorsoInput1_Click);
            // 
            // tabPageEsempio2
            // 
            this.tabPageEsempio2.Controls.Add(this.cartesianChart1);
            this.tabPageEsempio2.Controls.Add(this.pieChart1);
            this.tabPageEsempio2.Controls.Add(this.buttonEsempio2);
            this.tabPageEsempio2.Location = new System.Drawing.Point(4, 22);
            this.tabPageEsempio2.Name = "tabPageEsempio2";
            this.tabPageEsempio2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEsempio2.Size = new System.Drawing.Size(733, 425);
            this.tabPageEsempio2.TabIndex = 1;
            this.tabPageEsempio2.Text = "Esempio 2";
            this.tabPageEsempio2.UseVisualStyleBackColor = true;
            // 
            // buttonEsempio2
            // 
            this.buttonEsempio2.Location = new System.Drawing.Point(318, 382);
            this.buttonEsempio2.Name = "buttonEsempio2";
            this.buttonEsempio2.Size = new System.Drawing.Size(101, 37);
            this.buttonEsempio2.TabIndex = 0;
            this.buttonEsempio2.Text = "Apri python chart";
            this.buttonEsempio2.UseVisualStyleBackColor = true;
            this.buttonEsempio2.Click += new System.EventHandler(this.buttonEsempio2_Click);
            // 
            // pieChart1
            // 
            this.pieChart1.Location = new System.Drawing.Point(22, 13);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(337, 256);
            this.pieChart1.TabIndex = 1;
            this.pieChart1.Text = "pieChart1";
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Location = new System.Drawing.Point(398, 13);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(317, 273);
            this.cartesianChart1.TabIndex = 2;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // FormProccessi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 524);
            this.Controls.Add(this.tabControlMain);
            this.Name = "FormProccessi";
            this.Text = "Form Proccessi";
            this.tabControlMain.ResumeLayout(false);
            this.tabPageEsempio1.ResumeLayout(false);
            this.tabPageEsempio1.PerformLayout();
            this.tabPageEsempio2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialogInput;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageEsempio1;
        private System.Windows.Forms.TabPage tabPageEsempio2;
        private System.Windows.Forms.Button buttonCaricaInput1;
        private System.Windows.Forms.TextBox textBoxPercorsoInput1;
        private System.Windows.Forms.Button buttonOttimizza;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDistanzaMedia;
        private System.Windows.Forms.Label labelNumeroPunti;
        private System.Windows.Forms.RichTextBox richTextBoxMatrix;
        private System.Windows.Forms.Button buttonEsempio2;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private LiveCharts.WinForms.PieChart pieChart1;
    }
}

