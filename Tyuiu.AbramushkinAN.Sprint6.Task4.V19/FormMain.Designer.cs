namespace Tyuiu.AbramushkinAN.Sprint6.Task4.V19
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_AAN));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxCondition_AAN = new GroupBox();
            textBoxCondition_AAN = new TextBox();
            groupBoxInput_AAN = new GroupBox();
            textBoxInputStop_AAN = new TextBox();
            textBoxInputStart_AAN = new TextBox();
            textBoxStop_AAN = new TextBox();
            textBoxStart_AAN = new TextBox();
            groupBoxOutput_AAN = new GroupBox();
            chartFunction_AAN = new System.Windows.Forms.DataVisualization.Charting.Chart();
            textBoxResult_AAN = new TextBox();
            buttonStart_AAN = new Button();
            buttonSave_AAN = new Button();
            buttonHelp_AAN = new Button();
            groupBoxCondition_AAN.SuspendLayout();
            groupBoxInput_AAN.SuspendLayout();
            groupBoxOutput_AAN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_AAN).BeginInit();
            SuspendLayout();
            // 
            // groupBoxCondition_AAN
            // 
            groupBoxCondition_AAN.Controls.Add(textBoxCondition_AAN);
            groupBoxCondition_AAN.Location = new Point(12, 12);
            groupBoxCondition_AAN.Name = "groupBoxCondition_AAN";
            groupBoxCondition_AAN.Size = new Size(621, 129);
            groupBoxCondition_AAN.TabIndex = 0;
            groupBoxCondition_AAN.TabStop = false;
            groupBoxCondition_AAN.Text = "Условие:";
            // 
            // textBoxCondition_AAN
            // 
            textBoxCondition_AAN.BackColor = SystemColors.Control;
            textBoxCondition_AAN.Location = new Point(6, 22);
            textBoxCondition_AAN.Multiline = true;
            textBoxCondition_AAN.Name = "textBoxCondition_AAN";
            textBoxCondition_AAN.ReadOnly = true;
            textBoxCondition_AAN.Size = new Size(609, 101);
            textBoxCondition_AAN.TabIndex = 0;
            textBoxCondition_AAN.Text = resources.GetString("textBoxCondition_AAN.Text");
            // 
            // groupBoxInput_AAN
            // 
            groupBoxInput_AAN.Controls.Add(textBoxInputStop_AAN);
            groupBoxInput_AAN.Controls.Add(textBoxInputStart_AAN);
            groupBoxInput_AAN.Controls.Add(textBoxStop_AAN);
            groupBoxInput_AAN.Controls.Add(textBoxStart_AAN);
            groupBoxInput_AAN.Location = new Point(639, 12);
            groupBoxInput_AAN.Name = "groupBoxInput_AAN";
            groupBoxInput_AAN.Size = new Size(265, 129);
            groupBoxInput_AAN.TabIndex = 1;
            groupBoxInput_AAN.TabStop = false;
            groupBoxInput_AAN.Text = "Ввод данных:";
            groupBoxInput_AAN.Enter += groupBox1_Enter;
            // 
            // textBoxInputStop_AAN
            // 
            textBoxInputStop_AAN.Location = new Point(142, 61);
            textBoxInputStop_AAN.Multiline = true;
            textBoxInputStop_AAN.Name = "textBoxInputStop_AAN";
            textBoxInputStop_AAN.Size = new Size(100, 34);
            textBoxInputStop_AAN.TabIndex = 3;
            // 
            // textBoxInputStart_AAN
            // 
            textBoxInputStart_AAN.Location = new Point(6, 61);
            textBoxInputStart_AAN.Multiline = true;
            textBoxInputStart_AAN.Name = "textBoxInputStart_AAN";
            textBoxInputStart_AAN.Size = new Size(100, 34);
            textBoxInputStart_AAN.TabIndex = 2;
            // 
            // textBoxStop_AAN
            // 
            textBoxStop_AAN.BackColor = SystemColors.Control;
            textBoxStop_AAN.BorderStyle = BorderStyle.None;
            textBoxStop_AAN.Location = new Point(142, 39);
            textBoxStop_AAN.Name = "textBoxStop_AAN";
            textBoxStop_AAN.ReadOnly = true;
            textBoxStop_AAN.Size = new Size(100, 16);
            textBoxStop_AAN.TabIndex = 1;
            textBoxStop_AAN.Text = "Конец шага:";
            // 
            // textBoxStart_AAN
            // 
            textBoxStart_AAN.BackColor = SystemColors.Control;
            textBoxStart_AAN.BorderStyle = BorderStyle.None;
            textBoxStart_AAN.Location = new Point(6, 39);
            textBoxStart_AAN.Name = "textBoxStart_AAN";
            textBoxStart_AAN.ReadOnly = true;
            textBoxStart_AAN.Size = new Size(100, 16);
            textBoxStart_AAN.TabIndex = 0;
            textBoxStart_AAN.Text = "Старт шага:";
            // 
            // groupBoxOutput_AAN
            // 
            groupBoxOutput_AAN.Controls.Add(chartFunction_AAN);
            groupBoxOutput_AAN.Controls.Add(textBoxResult_AAN);
            groupBoxOutput_AAN.Location = new Point(12, 147);
            groupBoxOutput_AAN.Name = "groupBoxOutput_AAN";
            groupBoxOutput_AAN.Size = new Size(1312, 527);
            groupBoxOutput_AAN.TabIndex = 2;
            groupBoxOutput_AAN.TabStop = false;
            groupBoxOutput_AAN.Text = "Вывод:";
            // 
            // chartFunction_AAN
            // 
            chartArea2.Name = "ChartArea1";
            chartFunction_AAN.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartFunction_AAN.Legends.Add(legend2);
            chartFunction_AAN.Location = new Point(359, 22);
            chartFunction_AAN.Name = "chartFunction_AAN";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartFunction_AAN.Series.Add(series2);
            chartFunction_AAN.Size = new Size(947, 499);
            chartFunction_AAN.TabIndex = 1;
            chartFunction_AAN.Text = "chart1";
            // 
            // textBoxResult_AAN
            // 
            textBoxResult_AAN.Location = new Point(6, 22);
            textBoxResult_AAN.Multiline = true;
            textBoxResult_AAN.Name = "textBoxResult_AAN";
            textBoxResult_AAN.ReadOnly = true;
            textBoxResult_AAN.ScrollBars = ScrollBars.Vertical;
            textBoxResult_AAN.Size = new Size(347, 499);
            textBoxResult_AAN.TabIndex = 0;
            // 
            // buttonStart_AAN
            // 
            buttonStart_AAN.BackColor = Color.Green;
            buttonStart_AAN.Location = new Point(1190, 67);
            buttonStart_AAN.Name = "buttonStart_AAN";
            buttonStart_AAN.Size = new Size(134, 68);
            buttonStart_AAN.TabIndex = 3;
            buttonStart_AAN.Text = "Выполнить";
            buttonStart_AAN.UseVisualStyleBackColor = false;
            buttonStart_AAN.Click += buttonStart_AAN_Click;
            // 
            // buttonSave_AAN
            // 
            buttonSave_AAN.BackColor = Color.DodgerBlue;
            buttonSave_AAN.Location = new Point(1050, 67);
            buttonSave_AAN.Name = "buttonSave_AAN";
            buttonSave_AAN.Size = new Size(134, 68);
            buttonSave_AAN.TabIndex = 4;
            buttonSave_AAN.Text = "Сохранить";
            buttonSave_AAN.UseVisualStyleBackColor = false;
            buttonSave_AAN.Click += buttonSave_AAN_Click;
            // 
            // buttonHelp_AAN
            // 
            buttonHelp_AAN.BackColor = Color.FromArgb(0, 192, 192);
            buttonHelp_AAN.Location = new Point(910, 67);
            buttonHelp_AAN.Name = "buttonHelp_AAN";
            buttonHelp_AAN.Size = new Size(134, 68);
            buttonHelp_AAN.TabIndex = 5;
            buttonHelp_AAN.Text = "Справка";
            buttonHelp_AAN.UseVisualStyleBackColor = false;
            buttonHelp_AAN.Click += buttonHelp_AAN_Click;
            // 
            // FormMain_AAN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1336, 686);
            Controls.Add(buttonHelp_AAN);
            Controls.Add(buttonSave_AAN);
            Controls.Add(buttonStart_AAN);
            Controls.Add(groupBoxOutput_AAN);
            Controls.Add(groupBoxInput_AAN);
            Controls.Add(groupBoxCondition_AAN);
            Name = "FormMain_AAN";
            Text = "Спринт 6 | Таск 4 | Вариант 19 | Абрамушкин А.Н.";
            groupBoxCondition_AAN.ResumeLayout(false);
            groupBoxCondition_AAN.PerformLayout();
            groupBoxInput_AAN.ResumeLayout(false);
            groupBoxInput_AAN.PerformLayout();
            groupBoxOutput_AAN.ResumeLayout(false);
            groupBoxOutput_AAN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_AAN).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition_AAN;
        private GroupBox groupBoxInput_AAN;
        private GroupBox groupBoxOutput_AAN;
        private TextBox textBoxResult_AAN;
        private TextBox textBoxCondition_AAN;
        private TextBox textBoxInputStart_AAN;
        private TextBox textBoxStop_AAN;
        private TextBox textBoxStart_AAN;
        private TextBox textBoxInputStop_AAN;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_AAN;
        private Button buttonStart_AAN;
        private Button buttonSave_AAN;
        private Button buttonHelp_AAN;
    }
}
