using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace PlotExpression
{
    public partial class Form1 : Form
    {
        List<double> lst = new List<double>();
        public Form1()
        {
            InitializeComponent();
           // textBox1.TextChanged += textBox1_TextChanged;
        }

        private void buildPlot_Click(object sender, EventArgs e)
        {
            chart1.ChartAreas[0].AxisX.ScaleView.Zoom(0, 50);
            chart1.ChartAreas[0].CursorX.IsUserEnabled = true;
            chart1.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chart1.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chart1.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;

            chart1.ChartAreas[0].AxisY.ScaleView.Zoom(-20, 20);
            chart1.ChartAreas[0].CursorY.IsUserEnabled = true;
            chart1.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
            chart1.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
            chart1.ChartAreas[0].AxisY.ScrollBar.IsPositionedInside = true;
           
            for (int i = 0; i < 50; i++) {
                chart1.Series[0].Points.AddXY(i, Operation.Formula(i));
                lst.Add(Operation.Formula(i));
            }
        }

        private void clearPlot_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            lst.Clear();
        }

        private void writeFile_Click(object sender, EventArgs e)
        {
            try
            {
                // path D:\programmC#\TextWriting.txt
                string path = textBox1.Text;
                Operation.writeInFile(path, lst);
                MessageBox.Show("Запись прошла успешно");
            }
            catch (IOException) {
                MessageBox.Show("Ошибка при записи в файл");
            }
           
        }
    }
}
