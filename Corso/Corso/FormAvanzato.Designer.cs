namespace Corso
{
    partial class FormAvanzato
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
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonRadice = new System.Windows.Forms.Button();
            this.buttonLog10 = new System.Windows.Forms.Button();
            this.buttonLog2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelValueInput = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelValueSoluzione = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(190, 363);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(110, 62);
            this.buttonOk.TabIndex = 0;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(483, 363);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(110, 62);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonRadice
            // 
            this.buttonRadice.Location = new System.Drawing.Point(39, 79);
            this.buttonRadice.Name = "buttonRadice";
            this.buttonRadice.Size = new System.Drawing.Size(173, 71);
            this.buttonRadice.TabIndex = 2;
            this.buttonRadice.Text = "Radice quadrata";
            this.buttonRadice.UseVisualStyleBackColor = true;
            this.buttonRadice.Click += new System.EventHandler(this.buttonRadice_Click);
            // 
            // buttonLog10
            // 
            this.buttonLog10.Location = new System.Drawing.Point(329, 79);
            this.buttonLog10.Name = "buttonLog10";
            this.buttonLog10.Size = new System.Drawing.Size(173, 71);
            this.buttonLog10.TabIndex = 3;
            this.buttonLog10.Text = "Log10";
            this.buttonLog10.UseVisualStyleBackColor = true;
            this.buttonLog10.Click += new System.EventHandler(this.buttonLog10_Click);
            // 
            // buttonLog2
            // 
            this.buttonLog2.Location = new System.Drawing.Point(588, 79);
            this.buttonLog2.Name = "buttonLog2";
            this.buttonLog2.Size = new System.Drawing.Size(173, 71);
            this.buttonLog2.TabIndex = 4;
            this.buttonLog2.Text = "Log2";
            this.buttonLog2.UseVisualStyleBackColor = true;
            this.buttonLog2.Click += new System.EventHandler(this.buttonLog2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.8F);
            this.label1.Location = new System.Drawing.Point(30, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "Input:";
            // 
            // labelValueInput
            // 
            this.labelValueInput.AutoSize = true;
            this.labelValueInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.8F);
            this.labelValueInput.Location = new System.Drawing.Point(127, 230);
            this.labelValueInput.Name = "labelValueInput";
            this.labelValueInput.Size = new System.Drawing.Size(105, 39);
            this.labelValueInput.TabIndex = 6;
            this.labelValueInput.Text = "Value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.8F);
            this.label3.Location = new System.Drawing.Point(322, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 39);
            this.label3.TabIndex = 7;
            this.label3.Text = "Soluzione:";
            // 
            // labelValueSoluzione
            // 
            this.labelValueSoluzione.AutoSize = true;
            this.labelValueSoluzione.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.8F);
            this.labelValueSoluzione.Location = new System.Drawing.Point(507, 230);
            this.labelValueSoluzione.Name = "labelValueSoluzione";
            this.labelValueSoluzione.Size = new System.Drawing.Size(105, 39);
            this.labelValueSoluzione.TabIndex = 8;
            this.labelValueSoluzione.Text = "Value";
            // 
            // FormAvanzato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelValueSoluzione);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelValueInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLog2);
            this.Controls.Add(this.buttonLog10);
            this.Controls.Add(this.buttonRadice);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAvanzato";
            this.ShowIcon = false;
            this.Text = "Avanzato";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonRadice;
        private System.Windows.Forms.Button buttonLog10;
        private System.Windows.Forms.Button buttonLog2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelValueInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelValueSoluzione;
    }
}