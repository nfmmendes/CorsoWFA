using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CorsoLezione4
{
    public partial class FormProccessi : Form
    {
        List<List<double>> distanceMatrix; 
        public FormProccessi()
        {
            InitializeComponent();
        }

        bool validaInput()
        {
            //Se tutte le righe (sottoliste) hanno un singolo numero di elementi e se la somma di numero di elementi minori che 0 è uguale 0
            return distanceMatrix.Select(x => x.Count()).Distinct().Count() == 1 && distanceMatrix.Sum(x => x.Count(y => y < 0)) == 0;
        }


        private void buttonCaricaInput1_Click(object sender, EventArgs e)
        {
            using (var file = new StreamReader(openFileDialogInput.FileName))
            {
                string riga = "";
                distanceMatrix = new List<List<double>>(); 

                while( (riga  = file.ReadLine()) != null)
                {
                    var newValues = riga.Split(' ').Select(x => Convert.ToDouble(x)).ToList(); //Attenzione: Nessuna validazione è fatta qui!!
                    distanceMatrix.Add(newValues);
                }
            }

            if (validaInput())
            {
                labelDistanzaMedia.Text = distanceMatrix.Average(x => x.Average(y => y)).ToString();
                labelNumeroPunti.Text = distanceMatrix.Count().ToString();

                richTextBoxMatrix.Text = "";
                foreach (var lista in distanceMatrix)
                {
                    foreach (var elemento in lista)
                        richTextBoxMatrix.Text += elemento.ToString() + "\t";
                    richTextBoxMatrix.Text += "\n";
                }

                buttonOttimizza.Enabled = true;
            }
            else{
                MessageBox.Show("There are errors in your instance");
                buttonOttimizza.Enabled = false; 
            }
        }

        private void buttonOttimizza_Click(object sender, EventArgs e)
        {
            writeInputFileToSolver(); 
            var StartInfo = new ProcessStartInfo
            {
                FileName = @"C:\Users\NilsonFelipe\Desktop\run.exe",
                WorkingDirectory = @"C:\Users\NilsonFelipe\Desktop\",
                RedirectStandardInput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                Arguments = "_input.txt",
                CreateNoWindow = true
            };
            
            try
            {
                var proc = new Process();
                proc.StartInfo = StartInfo;
                var abriu = proc.Start();
                proc.WaitForExit();
                var ordine = readSolution().Split(' ').Where(x=>x != "").Select(x=>Convert.ToInt32(x)).ToList();
                MessageBox.Show("Ottimizzazione finita!");
                printCharts(ordine); 
            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception.Message);
            }
        }

        private void printCharts(List<int> ordine)
        {
            Func<ChartPoint, string> labelPoint = chartPoint => string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

            var series = new SeriesCollection();
            List<string> labels = new List<string>();
            var chartValues = new ChartValues<double>(); 

            for (int i = 1; i < ordine.Count(); i++){
                labels.Add($"{i - 1}");
                chartValues.Add(distanceMatrix[i-1][i]); 
                series.Add(new PieSeries()
                {
                    Title = $"Tratto {i - 1}",
                    Values = new ChartValues<double> { distanceMatrix[i - 1][i] },
                    DataLabels = true,
                    LabelPoint = labelPoint
                });

            }
            pieChart1.Series = series;
            pieChart1.LegendLocation = LegendLocation.Bottom;


            cartesianChart1.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Distance evolution",
                    Values = chartValues
                }
            };

            cartesianChart1.AxisX.Add(new Axis
            {
                Title = "Trato",
                Labels = labels
            });

            cartesianChart1.AxisY.Add(new Axis
            {
                Title = "Distanza",
                LabelFormatter = value => value.ToString("Km")
            });

        }

        private void writeInputFileToSolver()
        {
            using (var writer = new StreamWriter(@"C:\Users\NilsonFelipe\Desktop\_input.txt"))
            {
                writer.WriteLine(distanceMatrix.Count());
                foreach (var line in distanceMatrix)
                {
                    foreach (var value in line)
                        writer.Write(value + " ");
                    writer.Write("\n");
                }
            }
        }


        private string readSolution()
        {
            string solution; 
            using(var readFile = new StreamReader(@"C:\Users\NilsonFelipe\Desktop\exit.txt"))
            {
                solution = readFile.ReadLine(); 
            }

            return solution; 
        }

        private void textBoxPercorsoInput1_Click(object sender, EventArgs e)
        {
            openFileDialogInput.Filter = "File testo(*.txt)|*.txt";
            DialogResult result = openFileDialogInput.ShowDialog();
            var fileName = openFileDialogInput.FileName; 

            if (result == DialogResult.OK && !String.IsNullOrEmpty(fileName) ) {
                buttonCaricaInput1.Enabled = true;
                textBoxPercorsoInput1.Text = fileName;
                buttonOttimizza.Enabled = false; 
            }
        }

        private void buttonEsempio2_Click(object sender, EventArgs e)
        {
            var StartInfo = new ProcessStartInfo
            {
                FileName = "py.exe",
                WorkingDirectory = @"C:\Users\NilsonFelipe\Desktop\",
                RedirectStandardInput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                Arguments = @"C:\Users\NilsonFelipe\Desktop\run.py",
                CreateNoWindow = true
            };

            try
            {
                var proc = new Process();
                proc.StartInfo = StartInfo;
                var abriu = proc.Start();
                proc.WaitForExit();
            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception.Message);
            }
        }
    }
}
