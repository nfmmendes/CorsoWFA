using NPOI.SS.UserModel;
using NPOI.SS.Util;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lezione3
{
    public partial class Form1 : Form
    {
        public Form1()

        {
            InitializeComponent();
        }

        private void textBoxFileNameTxt_Click(object sender, EventArgs e)
        {
            openFileDialogText.FileName = "";
            openFileDialogText.Filter = "File text (*.txt)|*.txt";
            openFileDialogText.ShowDialog();
            var filePath = openFileDialogText.FileName;
            var fileName = openFileDialogText.SafeFileName;

            textBoxFileNameTxt.Text = filePath;
            buttonCaricaTxt.Enabled = (!String.IsNullOrEmpty(fileName));
            
        }

        private void buttonCaricaTxt_Click(object sender, EventArgs e)
        {
            var filePath = openFileDialogText.FileName;
            StreamReader input = new System.IO.StreamReader(@filePath);

            string text;
            int contaRighe = 0; 
            while ((text = input.ReadLine()) != null) {
                var splittedLine = text.Split(',');
                if (splittedLine.Length == 3)
                    richTextBoxInput.Text += ($"Riga {contaRighe++}: Regione = {splittedLine[0]} \t Provincia= " +
                                              $"{splittedLine[1]} Popolazione = {splittedLine[2]}\n\n");
            }
        }

        private void buttonRegistraTxt_Click(object sender, EventArgs e)
        {
            string[] lines = { "Prima riga", "Seconda riga", "Terza riga" };
            var fileName = saveFileDialogText.FileName;

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(fileName)){
                foreach (string line in lines)
                        file.WriteLine(line);
            }

        }

        private void textBoxRegistraFileTxt_Click(object sender, EventArgs e)
        {
            saveFileDialogText.Filter = "File text (*.txt)|*.txt";
            saveFileDialogText.ShowDialog();
            
            var fileName = saveFileDialogText.FileName;

            buttonRegistraTxt.Enabled = !String.IsNullOrEmpty(fileName);
            textBoxRegistraFileTxt.Text = fileName; 
        }

        private void buttonCaricaExcel_Click(object sender, EventArgs e)
        {
            leggeFileExcel(textBoxInputExcel.Text);
        }

        private void textBoxInputExcel_Click(object sender, EventArgs e)
        {
            openFileDialogText.FileName = "";
            openFileDialogText.Filter = "File Microsoft Office Excel (*.xlsx)|*.xlsx";
            openFileDialogText.ShowDialog();
            var filePath = openFileDialogText.FileName;
            var fileName = openFileDialogText.SafeFileName;

            textBoxInputExcel.Text = filePath;
            buttonCaricaExcel.Enabled = (!String.IsNullOrEmpty(fileName));
        }

        private void textBoxOutputExcel_Click(object sender, EventArgs e)
        {

            saveFileDialogText.Filter = "File Microsoft Office Excel (*.xlsx)|*.xlsx";
            saveFileDialogText.ShowDialog();

            var fileName = saveFileDialogText.FileName;

            buttonRegistraExcel.Enabled = !String.IsNullOrEmpty(fileName);
            textBoxOutputExcel.Text = fileName;
           
        }

        private void buttonRegistraExcel_Click(object sender, EventArgs e)
        {
            registraFileExcel(textBoxOutputExcel.Text);
        }


        private void leggeFileExcel(string percorso)
        {
            using (var stream = new FileStream(percorso, FileMode.Open, FileAccess.ReadWrite, FileShare.Read))
            {
                stream.Position = 0;

                XSSFWorkbook workbook = new XSSFWorkbook(stream); //This will read 2007 Excel format  
                ISheet sheet = workbook.GetSheet("Esempio 1");

                if (sheet != null)
                {
                    for (int i = sheet.FirstRowNum + 1; i <= sheet.LastRowNum; i++)
                    {
                        var row = sheet.GetRow(i);
                        if(row.GetCell(0).CellType == CellType.String && row.GetCell(1).CellType == CellType.String && row.GetCell(2).CellType == CellType.Numeric)
                            MessageBox.Show(row.GetCell(0).StringCellValue + " " + 
                                            row.GetCell(1).StringCellValue + " " + 
                                            row.GetCell(2).NumericCellValue);
                    }
                }
            }
        }

        private void registraFileExcel(string percorso){

            XSSFWorkbook wb = new XSSFWorkbook();
            XSSFSheet resultsSheet = (XSSFSheet)wb.CreateSheet("Esempio 2");

            var fontBold = wb.CreateFont();
            fontBold.FontHeightInPoints = 16;
            fontBold.FontName = "Calibri";
            fontBold.IsBold = true;

            XSSFCellStyle boldStyle = (XSSFCellStyle)wb.CreateCellStyle();
            boldStyle.SetFont(fontBold);

            resultsSheet.CreateRow(0);
            resultsSheet.GetRow(0).CreateCell(0);       resultsSheet.GetRow(0).CreateCell(1);       resultsSheet.GetRow(0).CreateCell(2);
            resultsSheet.GetRow(0).RowStyle = boldStyle;

            resultsSheet.GetRow(0).GetCell(0).SetCellValue("Item");
            resultsSheet.GetRow(0).GetCell(1).SetCellValue("Descrizione");
            resultsSheet.GetRow(0).GetCell(2).SetCellValue("Quant.");

            resultsSheet.CreateRow(1);
            resultsSheet.GetRow(1).CreateCell(0);       resultsSheet.GetRow(1).CreateCell(1);       resultsSheet.GetRow(1).CreateCell(2);
            resultsSheet.GetRow(1).GetCell(0).SetCellValue("IT1");
            resultsSheet.GetRow(1).GetCell(1).SetCellValue("Primo prodotto");
            resultsSheet.GetRow(1).GetCell(2).SetCellValue(10);

            resultsSheet.CreateRow(2);
            for (int i = 0; i < 10; i++) resultsSheet.GetRow(2).CreateCell(i);
            resultsSheet.AddMergedRegion(new CellRangeAddress(2, 2, 0, 9));
            resultsSheet.GetRow(2).GetCell(0).SetCellValue("Merge");

            using (FileStream fs = new FileStream(@percorso, FileMode.Create, FileAccess.Write))
            {
                wb.Write(fs);
            }

        }
    }
}
