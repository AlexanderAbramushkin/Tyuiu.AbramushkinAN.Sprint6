namespace Tyuiu.AbramushkinAN.Sprint6.Task2.V20
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
            GroupBoxCondition_AAN = new GroupBox();
            TextBoxCondition_AAN = new TextBox();
            GroupBoxInput_AAN = new GroupBox();
            TextBoxStopStep_AAN = new TextBox();
            TextBoxStartStep_AAN = new TextBox();
            TextBoxInputStopStep_AAN = new TextBox();
            TextBoxInputStartStep_AAN = new TextBox();
            ButtonHelp_AAN = new Button();
            ButtonStart_AAN = new Button();
            dataGridViewFunction_AAN = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            F = new DataGridViewTextBoxColumn();
            GroupBoxOutput_AAN = new GroupBox();
            ChartFunction_AAN = new System.Windows.Forms.DataVisualization.Charting.Chart();
            TextBoxResult_AAN = new TextBox();
            GroupBoxCondition_AAN.SuspendLayout();
            GroupBoxInput_AAN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_AAN).BeginInit();
            GroupBoxOutput_AAN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ChartFunction_AAN).BeginInit();
            SuspendLayout();
            // 
            // GroupBoxCondition_AAN
            // 
            GroupBoxCondition_AAN.Controls.Add(TextBoxCondition_AAN);
            GroupBoxCondition_AAN.Location = new Point(12, 12);
            GroupBoxCondition_AAN.Name = "GroupBoxCondition_AAN";
            GroupBoxCondition_AAN.Size = new Size(538, 285);
            GroupBoxCondition_AAN.TabIndex = 0;
            GroupBoxCondition_AAN.TabStop = false;
            GroupBoxCondition_AAN.Text = "Условие:";
            // 
            // TextBoxCondition_AAN
            // 
            TextBoxCondition_AAN.BackColor = SystemColors.Control;
            TextBoxCondition_AAN.BorderStyle = BorderStyle.None;
            TextBoxCondition_AAN.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            TextBoxCondition_AAN.Location = new Point(6, 22);
            TextBoxCondition_AAN.Multiline = true;
            TextBoxCondition_AAN.Name = "TextBoxCondition_AAN";
            TextBoxCondition_AAN.Size = new Size(521, 189);
            TextBoxCondition_AAN.TabIndex = 0;
            TextBoxCondition_AAN.Text = resources.GetString("TextBoxCondition_AAN.Text");
            // 
            // GroupBoxInput_AAN
            // 
            GroupBoxInput_AAN.Controls.Add(TextBoxStopStep_AAN);
            GroupBoxInput_AAN.Controls.Add(TextBoxStartStep_AAN);
            GroupBoxInput_AAN.Controls.Add(TextBoxInputStopStep_AAN);
            GroupBoxInput_AAN.Controls.Add(TextBoxInputStartStep_AAN);
            GroupBoxInput_AAN.Controls.Add(ButtonHelp_AAN);
            GroupBoxInput_AAN.Controls.Add(ButtonStart_AAN);
            GroupBoxInput_AAN.Location = new Point(18, 303);
            GroupBoxInput_AAN.Name = "GroupBoxInput_AAN";
            GroupBoxInput_AAN.Size = new Size(532, 100);
            GroupBoxInput_AAN.TabIndex = 1;
            GroupBoxInput_AAN.TabStop = false;
            GroupBoxInput_AAN.Text = "Ввод данных:";
            GroupBoxInput_AAN.Enter += groupBox1_Enter;
            // 
            // TextBoxStopStep_AAN
            // 
            TextBoxStopStep_AAN.BackColor = SystemColors.Control;
            TextBoxStopStep_AAN.BorderStyle = BorderStyle.None;
            TextBoxStopStep_AAN.Location = new Point(135, 31);
            TextBoxStopStep_AAN.Name = "TextBoxStopStep_AAN";
            TextBoxStopStep_AAN.Size = new Size(100, 16);
            TextBoxStopStep_AAN.TabIndex = 5;
            TextBoxStopStep_AAN.Text = "Конец шага:";
            // 
            // TextBoxStartStep_AAN
            // 
            TextBoxStartStep_AAN.BackColor = SystemColors.Control;
            TextBoxStartStep_AAN.BorderStyle = BorderStyle.None;
            TextBoxStartStep_AAN.Location = new Point(6, 31);
            TextBoxStartStep_AAN.Name = "TextBoxStartStep_AAN";
            TextBoxStartStep_AAN.Size = new Size(100, 16);
            TextBoxStartStep_AAN.TabIndex = 4;
            TextBoxStartStep_AAN.Text = "Старт шага:";
            TextBoxStartStep_AAN.TextChanged += textBox1_TextChanged;
            // 
            // TextBoxInputStopStep_AAN
            // 
            TextBoxInputStopStep_AAN.Location = new Point(135, 60);
            TextBoxInputStopStep_AAN.Name = "TextBoxInputStopStep_AAN";
            TextBoxInputStopStep_AAN.Size = new Size(114, 23);
            TextBoxInputStopStep_AAN.TabIndex = 3;
            TextBoxInputStopStep_AAN.TextChanged += textBox1_TextChanged;
            // 
            // TextBoxInputStartStep_AAN
            // 
            TextBoxInputStartStep_AAN.Location = new Point(6, 60);
            TextBoxInputStartStep_AAN.Name = "TextBoxInputStartStep_AAN";
            TextBoxInputStartStep_AAN.Size = new Size(114, 23);
            TextBoxInputStartStep_AAN.TabIndex = 2;
            TextBoxInputStartStep_AAN.TextChanged += textBox1_TextChanged;
            // 
            // ButtonHelp_AAN
            // 
            ButtonHelp_AAN.BackColor = Color.MediumSlateBlue;
            ButtonHelp_AAN.Location = new Point(267, 22);
            ButtonHelp_AAN.Name = "ButtonHelp_AAN";
            ButtonHelp_AAN.Size = new Size(124, 61);
            ButtonHelp_AAN.TabIndex = 1;
            ButtonHelp_AAN.Text = "Справка";
            ButtonHelp_AAN.UseVisualStyleBackColor = false;
            ButtonHelp_AAN.Click += ButtonHelp;
            ButtonHelp_AAN.MouseEnter += ButtonHelp_MouseEnter;
            ButtonHelp_AAN.MouseLeave += ButtonHelp_MouseLeave;
            // 
            // ButtonStart_AAN
            // 
            ButtonStart_AAN.BackColor = Color.LimeGreen;
            ButtonStart_AAN.Location = new Point(397, 22);
            ButtonStart_AAN.Name = "ButtonStart_AAN";
            ButtonStart_AAN.Size = new Size(124, 61);
            ButtonStart_AAN.TabIndex = 0;
            ButtonStart_AAN.Text = "Выполнить";
            ButtonStart_AAN.UseVisualStyleBackColor = false;
            ButtonStart_AAN.Click += ButtonStart;
            ButtonStart_AAN.MouseEnter += ButtonStart_MouseEnter;
            ButtonStart_AAN.MouseLeave += ButtonStart_MouseLeave;
            // 
            // dataGridViewFunction_AAN
            // 
            dataGridViewFunction_AAN.BackgroundColor = SystemColors.Control;
            dataGridViewFunction_AAN.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewFunction_AAN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction_AAN.Columns.AddRange(new DataGridViewColumn[] { X, F });
            dataGridViewFunction_AAN.Location = new Point(7, 48);
            dataGridViewFunction_AAN.Name = "dataGridViewFunction_AAN";
            dataGridViewFunction_AAN.RowHeadersVisible = false;
            dataGridViewFunction_AAN.Size = new Size(135, 326);
            dataGridViewFunction_AAN.TabIndex = 2;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.Name = "X";
            X.Width = 50;
            // 
            // F
            // 
            F.HeaderText = "F(X)";
            F.Name = "F";
            F.ReadOnly = true;
            F.Width = 50;
            // 
            // GroupBoxOutput_AAN
            // 
            GroupBoxOutput_AAN.Controls.Add(ChartFunction_AAN);
            GroupBoxOutput_AAN.Controls.Add(TextBoxResult_AAN);
            GroupBoxOutput_AAN.Controls.Add(dataGridViewFunction_AAN);
            GroupBoxOutput_AAN.Location = new Point(556, 12);
            GroupBoxOutput_AAN.Name = "GroupBoxOutput_AAN";
            GroupBoxOutput_AAN.Size = new Size(745, 390);
            GroupBoxOutput_AAN.TabIndex = 3;
            GroupBoxOutput_AAN.TabStop = false;
            GroupBoxOutput_AAN.Text = "Вывод данных:";
            // 
            // ChartFunction_AAN
            // 
            chartArea2.Name = "ChartArea1";
            ChartFunction_AAN.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            ChartFunction_AAN.Legends.Add(legend2);
            ChartFunction_AAN.Location = new Point(207, 60);
            ChartFunction_AAN.Name = "ChartFunction_AAN";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            ChartFunction_AAN.Series.Add(series2);
            ChartFunction_AAN.Size = new Size(532, 300);
            ChartFunction_AAN.TabIndex = 4;
            ChartFunction_AAN.Text = "chart1";
            // 
            // TextBoxResult_AAN
            // 
            TextBoxResult_AAN.BackColor = SystemColors.Control;
            TextBoxResult_AAN.BorderStyle = BorderStyle.None;
            TextBoxResult_AAN.Location = new Point(6, 19);
            TextBoxResult_AAN.Name = "TextBoxResult_AAN";
            TextBoxResult_AAN.Size = new Size(100, 16);
            TextBoxResult_AAN.TabIndex = 3;
            TextBoxResult_AAN.Text = "Результат:";
            // 
            // FormMain_AAN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1313, 414);
            Controls.Add(GroupBoxOutput_AAN);
            Controls.Add(GroupBoxInput_AAN);
            Controls.Add(GroupBoxCondition_AAN);
            Name = "FormMain_AAN";
            Text = "Спринт 6 | Таск 2 | Вариант 20 | Абрамушкин А.Н.";
            GroupBoxCondition_AAN.ResumeLayout(false);
            GroupBoxCondition_AAN.PerformLayout();
            GroupBoxInput_AAN.ResumeLayout(false);
            GroupBoxInput_AAN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_AAN).EndInit();
            GroupBoxOutput_AAN.ResumeLayout(false);
            GroupBoxOutput_AAN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ChartFunction_AAN).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GroupBoxCondition_AAN;
        private TextBox TextBoxCondition_AAN;
        private GroupBox GroupBoxInput_AAN;
        private Button ButtonStart_AAN;
        private TextBox TextBoxStartStep_AAN;
        private TextBox TextBoxInputStopStep_AAN;
        private TextBox TextBoxInputStartStep_AAN;
        private Button ButtonHelp_AAN;
        private TextBox TextBoxStopStep_AAN;
        private DataGridView dataGridViewFunction_AAN;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn F;
        private GroupBox GroupBoxOutput_AAN;
        private TextBox TextBoxResult_AAN;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartFunction_AAN;
    }
}
