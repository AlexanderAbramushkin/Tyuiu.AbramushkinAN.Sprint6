namespace Tyuiu.AbramushkinAN.Sprint6.Task3.V6
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
            GroupBoxCondition_AAN = new GroupBox();
            MatrixInput_AAN = new DataGridView();
            TextBoxCondition_AAN = new TextBox();
            GroupBoxResult_AAN = new GroupBox();
            MatrixOutput_AAN = new DataGridView();
            ButtonStart_AAN = new Button();
            ButtonHelp_AAN = new Button();
            GroupBoxCondition_AAN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MatrixInput_AAN).BeginInit();
            GroupBoxResult_AAN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MatrixOutput_AAN).BeginInit();
            SuspendLayout();
            // 
            // GroupBoxCondition_AAN
            // 
            GroupBoxCondition_AAN.Controls.Add(MatrixInput_AAN);
            GroupBoxCondition_AAN.Controls.Add(TextBoxCondition_AAN);
            GroupBoxCondition_AAN.Location = new Point(12, 12);
            GroupBoxCondition_AAN.Name = "GroupBoxCondition_AAN";
            GroupBoxCondition_AAN.Size = new Size(620, 448);
            GroupBoxCondition_AAN.TabIndex = 0;
            GroupBoxCondition_AAN.TabStop = false;
            GroupBoxCondition_AAN.Text = "Условие:";
            // 
            // MatrixInput_AAN
            // 
            MatrixInput_AAN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MatrixInput_AAN.ColumnHeadersVisible = false;
            MatrixInput_AAN.Location = new Point(316, 87);
            MatrixInput_AAN.Name = "MatrixInput_AAN";
            MatrixInput_AAN.RowHeadersVisible = false;
            MatrixInput_AAN.Size = new Size(298, 296);
            MatrixInput_AAN.TabIndex = 1;
            // 
            // TextBoxCondition_AAN
            // 
            TextBoxCondition_AAN.BackColor = SystemColors.Control;
            TextBoxCondition_AAN.BorderStyle = BorderStyle.None;
            TextBoxCondition_AAN.Location = new Point(6, 22);
            TextBoxCondition_AAN.Multiline = true;
            TextBoxCondition_AAN.Name = "TextBoxCondition_AAN";
            TextBoxCondition_AAN.Size = new Size(285, 194);
            TextBoxCondition_AAN.TabIndex = 0;
            TextBoxCondition_AAN.Text = "Дан массив 5 на 5 элементов.\r\n Заменить четные значения в третьей строке на 0.\r\n\r\n  -2 -10  -8  11   1\r\n\r\n -15  -9  -4 -15  18\r\n\r\n -15  12   7   6   9\r\n\r\n -14 -10  10  18  -5\r\n\r\n  -1   7 -19 -19  -4";
            TextBoxCondition_AAN.TextChanged += TextBoxCondition_AAN_TextChanged;
            // 
            // GroupBoxResult_AAN
            // 
            GroupBoxResult_AAN.Controls.Add(MatrixOutput_AAN);
            GroupBoxResult_AAN.Location = new Point(638, 12);
            GroupBoxResult_AAN.Name = "GroupBoxResult_AAN";
            GroupBoxResult_AAN.Size = new Size(390, 448);
            GroupBoxResult_AAN.TabIndex = 1;
            GroupBoxResult_AAN.TabStop = false;
            GroupBoxResult_AAN.Text = "Вывод данных";
            // 
            // MatrixOutput_AAN
            // 
            MatrixOutput_AAN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MatrixOutput_AAN.ColumnHeadersVisible = false;
            MatrixOutput_AAN.Location = new Point(41, 87);
            MatrixOutput_AAN.Name = "MatrixOutput_AAN";
            MatrixOutput_AAN.RowHeadersVisible = false;
            MatrixOutput_AAN.Size = new Size(301, 296);
            MatrixOutput_AAN.TabIndex = 0;
            // 
            // ButtonStart_AAN
            // 
            ButtonStart_AAN.Location = new Point(854, 466);
            ButtonStart_AAN.Name = "ButtonStart_AAN";
            ButtonStart_AAN.Size = new Size(174, 45);
            ButtonStart_AAN.TabIndex = 2;
            ButtonStart_AAN.Text = "Выполнить";
            ButtonStart_AAN.UseVisualStyleBackColor = true;
            ButtonStart_AAN.Click += ButtonStart_Click;
            // 
            // ButtonHelp_AAN
            // 
            ButtonHelp_AAN.Location = new Point(794, 466);
            ButtonHelp_AAN.Name = "ButtonHelp_AAN";
            ButtonHelp_AAN.Size = new Size(54, 45);
            ButtonHelp_AAN.TabIndex = 3;
            ButtonHelp_AAN.Text = "?";
            ButtonHelp_AAN.UseVisualStyleBackColor = true;
            ButtonHelp_AAN.Click += ButtonHelp_Click;
            // 
            // FormMain_AAN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1039, 524);
            Controls.Add(ButtonHelp_AAN);
            Controls.Add(ButtonStart_AAN);
            Controls.Add(GroupBoxResult_AAN);
            Controls.Add(GroupBoxCondition_AAN);
            Name = "FormMain_AAN";
            Text = "Спринт 6 | Таск 3 | Вариант 6 | Абрамушкин А.Н.";
            Load += FormMain_AAN_Load;
            GroupBoxCondition_AAN.ResumeLayout(false);
            GroupBoxCondition_AAN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MatrixInput_AAN).EndInit();
            GroupBoxResult_AAN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MatrixOutput_AAN).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GroupBoxCondition_AAN;
        private TextBox TextBoxCondition_AAN;
        private GroupBox GroupBoxResult_AAN;
        private DataGridView MatrixInput_AAN;
        private DataGridView MatrixOutput_AAN;
        private Button ButtonStart_AAN;
        private Button ButtonHelp_AAN;
    }
}
