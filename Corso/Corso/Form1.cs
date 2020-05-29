using System;
using System.CodeDom;
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
    public partial class Form1 : Form
    {

        private double result;
        private char operation;
        private bool newNumberState; 

        public Form1()
        {
            result = 0;
            operation = ' ';
            newNumberState = true; 
            InitializeComponent();
            FillComboBoxRegione();

        }

        void FillComboBoxRegione() {
            comboBoxRegione.Items.AddRange(Provincia.Provincie.Select(x=>x.Regione).Distinct().ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
           DialogResult result = MessageBox.Show("Hai appena vinto un iPhone 10! Lo vuoi?", "Atenzione",  MessageBoxButtons.YesNo);
           
            if(result == DialogResult.Yes){
                labelResult.Text = "Scemo! Era una bufala!!"; 
            }else{
                labelResult.Text = "Che scemo sei tu!!";
            }
        }

        private void textBoxLeft_TextChanged(object sender, EventArgs e)
        {
            labelInferiore.Text = textBoxLeft.Text + " " + textBoxRight.Text;
        }

        private void textBoxRight_TextChanged(object sender, EventArgs e)
        {
            labelInferiore.Text = textBoxLeft.Text + " " + textBoxRight.Text;
        }

        private void textBoxCalc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)){
                e.Handled = true;
            }

            if ((e.KeyChar == '-') &&  ((sender as TextBox).Text.IndexOf('-') > -1) && ((sender as TextBox).Text.Length > 1) )
            {
                e.Handled = true;
                processNewOperation('-', Convert.ToDouble((sender as TextBox).Text));   
            }

        }


        private void processNewOperation(char op, double value) {

            if(operation == ' '){
                result = value;
            }
            else if(operation == '+'){
                result += value;
            }
            else if (operation == '-'){
                result -= value;
            }
            else if (operation == 'x') {
                result *= value;
            }else if (operation == '/'){
                if(value != 0){
                    result /= value;
                }
                
            }

            textBoxCalc.Text = result.ToString();
            operation = op;
            newNumberState = true;
        }


        private void buttonPlus_Click(object sender, EventArgs e){
            processNewOperation('+', Convert.ToDouble(textBoxCalc.Text));
        }

        private void buttonMinus_Click(object sender, EventArgs e){
            if (textBoxCalc.Text.Length > 0)
                processNewOperation('-', Convert.ToDouble(textBoxCalc.Text));
            else{
                textBoxCalc.Text = "-";
                newNumberState = false; 
            }
        }

        private void buttonMultiply_Click(object sender, EventArgs e){
            processNewOperation('x', Convert.ToDouble(textBoxCalc.Text));
        }

        private void buttonDivide_Click(object sender, EventArgs e){
            processNewOperation('/', Convert.ToDouble(textBoxCalc.Text));
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            if (newNumberState == true)
                textBoxCalc.Text = "";
            newNumberState = false;
            textBoxCalc.Text = textBoxCalc.Text.Insert(Math.Min(textBoxCalc.Text.Length,textBoxCalc.SelectionStart), "0");
            textBoxCalc.SelectionStart++;
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            if (newNumberState == true)
                textBoxCalc.Text = "";
            newNumberState = false;
            textBoxCalc.Text = textBoxCalc.Text.Insert(Math.Min(textBoxCalc.Text.Length, textBoxCalc.SelectionStart), ".");
            textBoxCalc.SelectionStart++;
        }

        private void buttonBackSpace_Click(object sender, EventArgs e)
        {
          
        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            var previousPosition = textBoxCalc.SelectionStart; 
            if (newNumberState == true)
                textBoxCalc.Text = "";
            newNumberState = false;
            textBoxCalc.Text = textBoxCalc.Text.Insert(Math.Min(textBoxCalc.Text.Length, textBoxCalc.SelectionStart), "1");
            textBoxCalc.SelectionStart = Math.Min(textBoxCalc.Text.Length,  previousPosition+1); 
            
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            var previousPosition = textBoxCalc.SelectionStart;
            if (newNumberState == true)
                textBoxCalc.Text = "";
            newNumberState = false;
            textBoxCalc.Text = textBoxCalc.Text.Insert(Math.Min(textBoxCalc.Text.Length, textBoxCalc.SelectionStart), "2");
            textBoxCalc.SelectionStart = Math.Min(textBoxCalc.Text.Length, textBoxCalc.SelectionStart) + 1;
            textBoxCalc.SelectionStart = Math.Min(textBoxCalc.Text.Length, previousPosition + 1);
        }

        private void buttonThree_Click(object sender, EventArgs e)
        {
            var previousPosition = textBoxCalc.SelectionStart;
            if (newNumberState == true)
                textBoxCalc.Text = "";
            newNumberState = false;
            textBoxCalc.Text = textBoxCalc.Text.Insert(Math.Min(textBoxCalc.Text.Length, textBoxCalc.SelectionStart), "3");
            textBoxCalc.SelectionStart = Math.Min(textBoxCalc.Text.Length, previousPosition + 1);
        }

        private void buttonFour_Click(object sender, EventArgs e)
        {
            var previousPosition = textBoxCalc.SelectionStart;
            if (newNumberState == true)
                textBoxCalc.Text = "";
            newNumberState = false;
            textBoxCalc.Text = textBoxCalc.Text.Insert(Math.Min(textBoxCalc.Text.Length, textBoxCalc.SelectionStart), "4");
            textBoxCalc.SelectionStart = Math.Min(textBoxCalc.Text.Length, previousPosition + 1);
        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
            var previousPosition = textBoxCalc.SelectionStart;
            if (newNumberState == true)
                textBoxCalc.Text = "";
            newNumberState = false;
            textBoxCalc.Text = textBoxCalc.Text.Insert(Math.Min(textBoxCalc.Text.Length, textBoxCalc.SelectionStart), "5");
            textBoxCalc.SelectionStart = Math.Min(textBoxCalc.Text.Length, previousPosition + 1);
        }

        private void buttonSix_Click(object sender, EventArgs e)
        {
            var previousPosition = textBoxCalc.SelectionStart;
            if (newNumberState == true)
                textBoxCalc.Text = "";
            newNumberState = false;
            textBoxCalc.Text = textBoxCalc.Text.Insert(Math.Min(textBoxCalc.Text.Length, textBoxCalc.SelectionStart), "6");
            textBoxCalc.SelectionStart = Math.Min(textBoxCalc.Text.Length, previousPosition + 1);
        }

        private void buttonSeven_Click(object sender, EventArgs e)
        {
            var previousPosition = textBoxCalc.SelectionStart;
            if (newNumberState == true)
                textBoxCalc.Text = "";
            newNumberState = false;
            textBoxCalc.Text = textBoxCalc.Text.Insert(Math.Min(textBoxCalc.Text.Length, textBoxCalc.SelectionStart), "7");
            textBoxCalc.SelectionStart = Math.Min(textBoxCalc.Text.Length, previousPosition + 1);
        }

        private void buttonEight_Click(object sender, EventArgs e)
        {
            var previousPosition = textBoxCalc.SelectionStart;
            if (newNumberState == true)
                textBoxCalc.Text = "";
            newNumberState = false;
            textBoxCalc.Text = textBoxCalc.Text.Insert(Math.Min(textBoxCalc.Text.Length, textBoxCalc.SelectionStart), "8");
            textBoxCalc.SelectionStart = Math.Min(textBoxCalc.Text.Length, previousPosition + 1);
        }

        private void buttonNine_Click(object sender, EventArgs e)
        {
            var previousPosition = textBoxCalc.SelectionStart;
            if (newNumberState == true)
                textBoxCalc.Text = "";
            newNumberState = false; 
            textBoxCalc.Text = textBoxCalc.Text.Insert(Math.Min(textBoxCalc.Text.Length, textBoxCalc.SelectionStart), "9");
            textBoxCalc.SelectionStart = Math.Min(textBoxCalc.Text.Length, previousPosition + 1);
        }

        private void buttonAvanzato_Click(object sender, EventArgs e)
        {
            if (textBoxCalc.Text.Length > 0)
            {
                FormAvanzato form = new FormAvanzato();
                var result = form.openForEvaluate(Convert.ToDouble(textBoxCalc.Text));
                textBoxCalc.Text = result.ToString();
            }
            
        }

        private bool onlySymbol(string text){

            if (text.Length > 1 || text.Length == 0)
                return false;
            else {
                var symbol = text[0];
                return symbol == '-' || symbol == '.' || symbol == '/' || symbol == '*' || symbol == '+';
            }

        }


        private void textBoxCalc_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.textBoxCalc.Text) && !onlySymbol(this.textBoxCalc.Text)) {
                newNumberState = false;
                try
                {
                    double value = Convert.ToDouble(this.textBoxCalc.Text);
                    if (value > 0)
                        this.buttonAvanzato.Enabled = true;
                    else
                        this.buttonAvanzato.Enabled = false; 
                }catch(Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void comboBoxMesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(((ComboBox)sender).SelectedItem.ToString());
        }

        private void comboBoxRegione_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxProvincia.Enabled = true;
            var selectedItem = comboBoxRegione.SelectedItem.ToString();
            var items = Provincia.Provincie.Where(x => x.Regione == selectedItem).ToArray();
            comboBoxProvincia.Items.Clear();
            comboBoxProvincia.Items.Add(items);
        }

        private void buttonAbilitaPanel_Click(object sender, EventArgs e)
        {
            this.panelComboBox.Enabled = true; 
        }

        private void buttonDisabilitaPanel_Click(object sender, EventArgs e)
        {
            this.panelComboBox.Enabled = false;
        }
    }
}
