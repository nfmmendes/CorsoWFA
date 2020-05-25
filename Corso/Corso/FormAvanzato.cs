using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Corso
{
    public partial class FormAvanzato : Form
    {

        private double result;
        private bool isCalculated;
        private double input;

        public FormAvanzato()
        {
            result = 0;
            isCalculated = false;
            input = 0; 
            InitializeComponent();
        }

        public void openWindow()
        {
            this.Show(); 
        }

        public double openForEvaluate(double input)
        {
            this.input = input;
            this.ShowDialog();

            labelValueInput.Text = input.ToString();
            labelValueSoluzione.Text = "";

            return result; 
        }

        private void buttonRadice_Click(object sender, EventArgs e)
        {
            result = Math.Sqrt(input);
            labelValueSoluzione.Text = result.ToString();
            isCalculated = true; 
        }

        private void buttonLog10_Click(object sender, EventArgs e)
        {
            result = Math.Log10(input);
            labelValueSoluzione.Text = result.ToString();
            isCalculated = true; 
        }

        private void buttonLog2_Click(object sender, EventArgs e)
        {
            result = Math.Log10(input)/Math.Log10(2);
            labelValueSoluzione.Text = result.ToString();
            isCalculated = true; 
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (!isCalculated)
                result = input; 
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
