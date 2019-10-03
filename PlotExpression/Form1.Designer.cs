namespace PlotExpression
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buildPlot = new System.Windows.Forms.Button();
            this.clearPlot = new System.Windows.Forms.Button();
            this.writeFile = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(1, -2);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.LegendText = "Функция у";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(552, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title3.Name = "Title1";
            title3.Text = "График функции";
            this.chart1.Titles.Add(title3);
            // 
            // buildPlot
            // 
            this.buildPlot.Location = new System.Drawing.Point(12, 316);
            this.buildPlot.Name = "buildPlot";
            this.buildPlot.Size = new System.Drawing.Size(75, 23);
            this.buildPlot.TabIndex = 1;
            this.buildPlot.Text = "Построить";
            this.buildPlot.UseVisualStyleBackColor = true;
            this.buildPlot.Click += new System.EventHandler(this.buildPlot_Click);
            // 
            // clearPlot
            // 
            this.clearPlot.Location = new System.Drawing.Point(467, 316);
            this.clearPlot.Name = "clearPlot";
            this.clearPlot.Size = new System.Drawing.Size(75, 23);
            this.clearPlot.TabIndex = 2;
            this.clearPlot.Text = "Очистить ";
            this.clearPlot.UseVisualStyleBackColor = true;
            this.clearPlot.Click += new System.EventHandler(this.clearPlot_Click);
            // 
            // writeFile
            // 
            this.writeFile.Location = new System.Drawing.Point(332, 398);
            this.writeFile.Name = "writeFile";
            this.writeFile.Size = new System.Drawing.Size(75, 23);
            this.writeFile.TabIndex = 3;
            this.writeFile.Text = "Запись";
            this.writeFile.UseVisualStyleBackColor = true;
            this.writeFile.Click += new System.EventHandler(this.writeFile_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(133, 398);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(130, 373);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Введите текстовый файл для записи значений";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 492);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.writeFile);
            this.Controls.Add(this.clearPlot);
            this.Controls.Add(this.buildPlot);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "График";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button buildPlot;
        private System.Windows.Forms.Button clearPlot;
        private System.Windows.Forms.Button writeFile;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}

