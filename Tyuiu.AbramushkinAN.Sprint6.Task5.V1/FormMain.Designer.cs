namespace Tyuiu.AbramushkinAN.Sprint6.Task5.V1
{
    partial class FormMain_AAN
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxCondition_AAN = new GroupBox();
            textBoxCondition_AAN = new TextBox();
            groupBoxOutput_AAN = new GroupBox();
            chartFunction_AAN = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridViewResult_AAN = new DataGridView();
            buttonDone_AAN = new Button();
            buttonHelp_AAN = new Button();
            buttonOpen_AAN = new Button();
            groupBoxCondition_AAN.SuspendLayout();
            groupBoxOutput_AAN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_AAN).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_AAN).BeginInit();
            SuspendLayout();
            // 
            // groupBoxCondition_AAN
            // 
            groupBoxCondition_AAN.Controls.Add(textBoxCondition_AAN);
            groupBoxCondition_AAN.Location = new Point(12, 12);
            groupBoxCondition_AAN.Name = "groupBoxCondition_AAN";
            groupBoxCondition_AAN.Size = new Size(536, 78);
            groupBoxCondition_AAN.TabIndex = 0;
            groupBoxCondition_AAN.TabStop = false;
            groupBoxCondition_AAN.Text = "Условие:";
            // 
            // textBoxCondition_AAN
            // 
            textBoxCondition_AAN.BackColor = SystemColors.Control;
            textBoxCondition_AAN.BorderStyle = BorderStyle.None;
            textBoxCondition_AAN.Location = new Point(6, 14);
            textBoxCondition_AAN.Multiline = true;
            textBoxCondition_AAN.Name = "textBoxCondition_AAN";
            textBoxCondition_AAN.ReadOnly = true;
            textBoxCondition_AAN.Size = new Size(524, 58);
            textBoxCondition_AAN.TabIndex = 0;
            textBoxCondition_AAN.Text = "Прочитать данные из файла InPutFileTask5V1.txt. Вывести в DataGridView\r\nположительные значения и построить диаграмму по этим значениям.";
            // 
            // groupBoxOutput_AAN
            // 
            groupBoxOutput_AAN.Controls.Add(chartFunction_AAN);
            groupBoxOutput_AAN.Controls.Add(dataGridViewResult_AAN);
            groupBoxOutput_AAN.Location = new Point(12, 96);
            groupBoxOutput_AAN.Name = "groupBoxOutput_AAN";
            groupBoxOutput_AAN.Size = new Size(914, 443);
            groupBoxOutput_AAN.TabIndex = 1;
            groupBoxOutput_AAN.TabStop = false;
            groupBoxOutput_AAN.Text = "Вывод данных:";
            // 
            // chartFunction_AAN
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_AAN.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction_AAN.Legends.Add(legend1);
            chartFunction_AAN.Location = new Point(192, 22);
            chartFunction_AAN.Name = "chartFunction_AAN";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_AAN.Series.Add(series1);
            chartFunction_AAN.Size = new Size(716, 415);
            chartFunction_AAN.TabIndex = 1;
            chartFunction_AAN.Text = "chart1";
            // 
            // dataGridViewResult_AAN
            // 
            dataGridViewResult_AAN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_AAN.ColumnHeadersVisible = false;
            dataGridViewResult_AAN.Location = new Point(6, 22);
            dataGridViewResult_AAN.Name = "dataGridViewResult_AAN";
            dataGridViewResult_AAN.ReadOnly = true;
            dataGridViewResult_AAN.RowHeadersVisible = false;
            dataGridViewResult_AAN.Size = new Size(180, 415);
            dataGridViewResult_AAN.TabIndex = 0;
            // 
            // buttonDone_AAN
            // 
            buttonDone_AAN.BackColor = Color.FromArgb(0, 192, 0);
            buttonDone_AAN.Location = new Point(554, 26);
            buttonDone_AAN.Name = "buttonDone_AAN";
            buttonDone_AAN.Size = new Size(150, 64);
            buttonDone_AAN.TabIndex = 2;
            buttonDone_AAN.Text = "Выполнить";
            buttonDone_AAN.UseVisualStyleBackColor = false;
            buttonDone_AAN.Click += buttonDone_AAN_Click;
            // 
            // buttonHelp_AAN
            // 
            buttonHelp_AAN.BackColor = Color.FromArgb(128, 128, 255);
            buttonHelp_AAN.Location = new Point(821, 26);
            buttonHelp_AAN.Name = "buttonHelp_AAN";
            buttonHelp_AAN.Size = new Size(105, 64);
            buttonHelp_AAN.TabIndex = 3;
            buttonHelp_AAN.Text = "Справка";
            buttonHelp_AAN.UseVisualStyleBackColor = false;
            buttonHelp_AAN.Click += buttonHelp_AAN_Click;
            // 
            // buttonOpen_AAN
            // 
            buttonOpen_AAN.BackColor = Color.FromArgb(0, 192, 192);
            buttonOpen_AAN.Location = new Point(710, 26);
            buttonOpen_AAN.Name = "buttonOpen_AAN";
            buttonOpen_AAN.Size = new Size(105, 64);
            buttonOpen_AAN.TabIndex = 4;
            buttonOpen_AAN.Text = "Открыть файл";
            buttonOpen_AAN.UseVisualStyleBackColor = false;
            buttonOpen_AAN.Click += buttonOpen_AAN_Click;
            // 
            // FormMain_AAN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 551);
            Controls.Add(buttonOpen_AAN);
            Controls.Add(buttonHelp_AAN);
            Controls.Add(buttonDone_AAN);
            Controls.Add(groupBoxOutput_AAN);
            Controls.Add(groupBoxCondition_AAN);
            Name = "FormMain_AAN";
            Text = "Спринт 6 | Таск 5 | Вариант 1 | Абрамушкин А.Н.";
            groupBoxCondition_AAN.ResumeLayout(false);
            groupBoxCondition_AAN.PerformLayout();
            groupBoxOutput_AAN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartFunction_AAN).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_AAN).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition_AAN;
        private GroupBox groupBoxOutput_AAN;
        private Button buttonDone_AAN;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_AAN;
        private DataGridView dataGridViewResult_AAN;
        private Button buttonHelp_AAN;
        private Button buttonOpen_AAN;
        private TextBox textBoxCondition_AAN;
    }
}
