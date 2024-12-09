namespace Tyuiu.AbramushkinAN.Sprint6.Task1.V15
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
            groupBoxTask_AAN = new GroupBox();
            TextBoxCondition_AAN = new TextBox();
            GroupBoxInput_AAN = new GroupBox();
            TextBoxStopStep_AAN = new TextBox();
            TextBoxStartStep_AAN = new TextBox();
            TextBoxStopStepInput_AAN = new TextBox();
            TextBoxStartStepInput_AAN = new TextBox();
            GroupBoxOutput_AAN = new GroupBox();
            TextBoxOutputResult_AAN = new TextBox();
            TextBoxResult_AAN = new TextBox();
            ButtonHelp_AAN = new Button();
            ButtonLaunch_AAN = new Button();
            groupBoxTask_AAN.SuspendLayout();
            GroupBoxInput_AAN.SuspendLayout();
            GroupBoxOutput_AAN.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_AAN
            // 
            groupBoxTask_AAN.Controls.Add(TextBoxCondition_AAN);
            groupBoxTask_AAN.FlatStyle = FlatStyle.Flat;
            groupBoxTask_AAN.Location = new Point(12, 12);
            groupBoxTask_AAN.Name = "groupBoxTask_AAN";
            groupBoxTask_AAN.Size = new Size(517, 343);
            groupBoxTask_AAN.TabIndex = 0;
            groupBoxTask_AAN.TabStop = false;
            groupBoxTask_AAN.Text = "Условие:";
            groupBoxTask_AAN.Enter += groupBox1_Enter;
            // 
            // TextBoxCondition_AAN
            // 
            TextBoxCondition_AAN.BackColor = SystemColors.Menu;
            TextBoxCondition_AAN.BorderStyle = BorderStyle.None;
            TextBoxCondition_AAN.Font = new Font("Segoe UI", 15F);
            TextBoxCondition_AAN.Location = new Point(18, 22);
            TextBoxCondition_AAN.Multiline = true;
            TextBoxCondition_AAN.Name = "TextBoxCondition_AAN";
            TextBoxCondition_AAN.ReadOnly = true;
            TextBoxCondition_AAN.Size = new Size(493, 246);
            TextBoxCondition_AAN.TabIndex = 0;
            TextBoxCondition_AAN.Text = resources.GetString("TextBoxCondition_AAN.Text");
            TextBoxCondition_AAN.TextChanged += TextBoxCondition_AAN_TextChanged;
            // 
            // GroupBoxInput_AAN
            // 
            GroupBoxInput_AAN.Controls.Add(TextBoxStopStep_AAN);
            GroupBoxInput_AAN.Controls.Add(TextBoxStartStep_AAN);
            GroupBoxInput_AAN.Controls.Add(TextBoxStopStepInput_AAN);
            GroupBoxInput_AAN.Controls.Add(TextBoxStartStepInput_AAN);
            GroupBoxInput_AAN.Location = new Point(12, 361);
            GroupBoxInput_AAN.Name = "GroupBoxInput_AAN";
            GroupBoxInput_AAN.Size = new Size(270, 77);
            GroupBoxInput_AAN.TabIndex = 1;
            GroupBoxInput_AAN.TabStop = false;
            GroupBoxInput_AAN.Text = "Ввод данных:";
            // 
            // TextBoxStopStep_AAN
            // 
            TextBoxStopStep_AAN.BackColor = SystemColors.ButtonFace;
            TextBoxStopStep_AAN.BorderStyle = BorderStyle.None;
            TextBoxStopStep_AAN.Location = new Point(141, 22);
            TextBoxStopStep_AAN.Name = "TextBoxStopStep_AAN";
            TextBoxStopStep_AAN.ReadOnly = true;
            TextBoxStopStep_AAN.Size = new Size(100, 16);
            TextBoxStopStep_AAN.TabIndex = 5;
            TextBoxStopStep_AAN.Text = "Конец шага:";
            // 
            // TextBoxStartStep_AAN
            // 
            TextBoxStartStep_AAN.BackColor = SystemColors.ButtonFace;
            TextBoxStartStep_AAN.BorderStyle = BorderStyle.None;
            TextBoxStartStep_AAN.Location = new Point(18, 22);
            TextBoxStartStep_AAN.Name = "TextBoxStartStep_AAN";
            TextBoxStartStep_AAN.ReadOnly = true;
            TextBoxStartStep_AAN.Size = new Size(100, 16);
            TextBoxStartStep_AAN.TabIndex = 4;
            TextBoxStartStep_AAN.Text = "Старт шага:";
            // 
            // TextBoxStopStepInput_AAN
            // 
            TextBoxStopStepInput_AAN.Location = new Point(141, 44);
            TextBoxStopStepInput_AAN.Name = "TextBoxStopStepInput_AAN";
            TextBoxStopStepInput_AAN.Size = new Size(117, 23);
            TextBoxStopStepInput_AAN.TabIndex = 3;
            // 
            // TextBoxStartStepInput_AAN
            // 
            TextBoxStartStepInput_AAN.Location = new Point(18, 44);
            TextBoxStartStepInput_AAN.Name = "TextBoxStartStepInput_AAN";
            TextBoxStartStepInput_AAN.Size = new Size(117, 23);
            TextBoxStartStepInput_AAN.TabIndex = 2;
            TextBoxStartStepInput_AAN.TextChanged += textBox1_TextChanged;
            // 
            // GroupBoxOutput_AAN
            // 
            GroupBoxOutput_AAN.Controls.Add(TextBoxOutputResult_AAN);
            GroupBoxOutput_AAN.Controls.Add(TextBoxResult_AAN);
            GroupBoxOutput_AAN.Location = new Point(554, 12);
            GroupBoxOutput_AAN.Name = "GroupBoxOutput_AAN";
            GroupBoxOutput_AAN.Size = new Size(234, 426);
            GroupBoxOutput_AAN.TabIndex = 2;
            GroupBoxOutput_AAN.TabStop = false;
            GroupBoxOutput_AAN.Text = "Вывод данных:";
            GroupBoxOutput_AAN.Enter += groupBox1_Enter_1;
            // 
            // TextBoxOutputResult_AAN
            // 
            TextBoxOutputResult_AAN.BackColor = SystemColors.ButtonFace;
            TextBoxOutputResult_AAN.BorderStyle = BorderStyle.None;
            TextBoxOutputResult_AAN.Location = new Point(6, 44);
            TextBoxOutputResult_AAN.Multiline = true;
            TextBoxOutputResult_AAN.Name = "TextBoxOutputResult_AAN";
            TextBoxOutputResult_AAN.ReadOnly = true;
            TextBoxOutputResult_AAN.ScrollBars = ScrollBars.Vertical;
            TextBoxOutputResult_AAN.Size = new Size(222, 372);
            TextBoxOutputResult_AAN.TabIndex = 6;
            TextBoxOutputResult_AAN.TextChanged += TextBoxOutputResult_AAN_TextChanged;
            // 
            // TextBoxResult_AAN
            // 
            TextBoxResult_AAN.BackColor = SystemColors.ButtonFace;
            TextBoxResult_AAN.BorderStyle = BorderStyle.None;
            TextBoxResult_AAN.Location = new Point(6, 22);
            TextBoxResult_AAN.Name = "TextBoxResult_AAN";
            TextBoxResult_AAN.ReadOnly = true;
            TextBoxResult_AAN.Size = new Size(100, 16);
            TextBoxResult_AAN.TabIndex = 5;
            TextBoxResult_AAN.Text = "Результат: ";
            // 
            // ButtonHelp_AAN
            // 
            ButtonHelp_AAN.BackColor = Color.RoyalBlue;
            ButtonHelp_AAN.FlatStyle = FlatStyle.Flat;
            ButtonHelp_AAN.Location = new Point(304, 376);
            ButtonHelp_AAN.Name = "ButtonHelp_AAN";
            ButtonHelp_AAN.Size = new Size(110, 52);
            ButtonHelp_AAN.TabIndex = 0;
            ButtonHelp_AAN.Text = "Справка";
            ButtonHelp_AAN.UseVisualStyleBackColor = false;
            ButtonHelp_AAN.Click += TextBoxCondition_AAN_TextChanged;
            // 
            // ButtonLaunch_AAN
            // 
            ButtonLaunch_AAN.BackColor = Color.SeaGreen;
            ButtonLaunch_AAN.FlatStyle = FlatStyle.Flat;
            ButtonLaunch_AAN.Location = new Point(420, 376);
            ButtonLaunch_AAN.Name = "ButtonLaunch_AAN";
            ButtonLaunch_AAN.Size = new Size(110, 52);
            ButtonLaunch_AAN.TabIndex = 1;
            ButtonLaunch_AAN.Text = "Выполнить";
            ButtonLaunch_AAN.UseVisualStyleBackColor = false;
            ButtonLaunch_AAN.Click += ButtonLaunch_AAN_Click;
            // 
            // FormMain_AAN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ButtonLaunch_AAN);
            Controls.Add(ButtonHelp_AAN);
            Controls.Add(GroupBoxOutput_AAN);
            Controls.Add(GroupBoxInput_AAN);
            Controls.Add(groupBoxTask_AAN);
            Name = "FormMain_AAN";
            Text = "Спринт 6 | Таск 1 | Вариант 15 | Абрамушкин А.Н.";
            groupBoxTask_AAN.ResumeLayout(false);
            groupBoxTask_AAN.PerformLayout();
            GroupBoxInput_AAN.ResumeLayout(false);
            GroupBoxInput_AAN.PerformLayout();
            GroupBoxOutput_AAN.ResumeLayout(false);
            GroupBoxOutput_AAN.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_AAN;
        private TextBox TextBoxCondition_AAN;
        private GroupBox GroupBoxInput_AAN;
        private GroupBox GroupBoxOutput_AAN;
        private Button ButtonHelp_AAN;
        private TextBox TextBoxStartStep_AAN;
        private TextBox TextBoxStopStepInput_AAN;
        private TextBox TextBoxStartStepInput_AAN;
        private Button ButtonLaunch_AAN;
        private TextBox TextBoxStopStep_AAN;
        private TextBox TextBoxOutputResult_AAN;
        private TextBox TextBoxResult_AAN;
    }
}
