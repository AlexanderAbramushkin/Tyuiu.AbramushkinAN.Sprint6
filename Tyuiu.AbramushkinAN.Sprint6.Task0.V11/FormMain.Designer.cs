namespace Tyuiu.AbramushkinAN.Sprint6.Task0.V11
{
    partial class FormMain
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            GroupBox_AAN = new GroupBox();
            TextBox_AAN = new TextBox();
            PictureBoxFormula_AAN = new PictureBox();
            GroupBoxEnterX_AAN = new GroupBox();
            DataEnterX_AAN = new TextBox();
            TextBoxVarX = new TextBox();
            ButtonStart_AAN = new Button();
            ButtonQuestion_AAN = new Button();
            GroupBoxResult_AAN = new GroupBox();
            TextBoxResult_AAN = new TextBox();
            TextResult_AAN = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            GroupBox_AAN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBoxFormula_AAN).BeginInit();
            GroupBoxEnterX_AAN.SuspendLayout();
            GroupBoxResult_AAN.SuspendLayout();
            SuspendLayout();
            // 
            // GroupBox_AAN
            // 
            GroupBox_AAN.Controls.Add(TextBox_AAN);
            GroupBox_AAN.Font = new Font("Proxima Nova ExCn Rg", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 204);
            GroupBox_AAN.Location = new Point(41, 38);
            GroupBox_AAN.Name = "GroupBox_AAN";
            GroupBox_AAN.Size = new Size(471, 219);
            GroupBox_AAN.TabIndex = 0;
            GroupBox_AAN.TabStop = false;
            GroupBox_AAN.Text = "Условие:";
            GroupBox_AAN.Enter += groupBox1_Enter;
            // 
            // TextBox_AAN
            // 
            TextBox_AAN.BackColor = SystemColors.ButtonFace;
            TextBox_AAN.BorderStyle = BorderStyle.None;
            TextBox_AAN.Font = new Font("Proxima Nova ExCn Rg", 20.2499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TextBox_AAN.ForeColor = SystemColors.Desktop;
            TextBox_AAN.Location = new Point(6, 22);
            TextBox_AAN.Multiline = true;
            TextBox_AAN.Name = "TextBox_AAN";
            TextBox_AAN.ReadOnly = true;
            TextBox_AAN.Size = new Size(442, 37);
            TextBox_AAN.TabIndex = 0;
            TextBox_AAN.Text = "Вычислить выражение по формуле";
            // 
            // PictureBoxFormula_AAN
            // 
            PictureBoxFormula_AAN.Image = (Image)resources.GetObject("PictureBoxFormula_AAN.Image");
            PictureBoxFormula_AAN.Location = new Point(543, 60);
            PictureBoxFormula_AAN.Name = "PictureBoxFormula_AAN";
            PictureBoxFormula_AAN.Size = new Size(271, 52);
            PictureBoxFormula_AAN.TabIndex = 1;
            PictureBoxFormula_AAN.TabStop = false;
            // 
            // GroupBoxEnterX_AAN
            // 
            GroupBoxEnterX_AAN.BackgroundImageLayout = ImageLayout.None;
            GroupBoxEnterX_AAN.Controls.Add(DataEnterX_AAN);
            GroupBoxEnterX_AAN.Controls.Add(TextBoxVarX);
            GroupBoxEnterX_AAN.Font = new Font("Proxima Nova Cn Bl", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 204);
            GroupBoxEnterX_AAN.Location = new Point(47, 315);
            GroupBoxEnterX_AAN.Name = "GroupBoxEnterX_AAN";
            GroupBoxEnterX_AAN.Size = new Size(465, 133);
            GroupBoxEnterX_AAN.TabIndex = 2;
            GroupBoxEnterX_AAN.TabStop = false;
            GroupBoxEnterX_AAN.Text = "Ввод данных";
            // 
            // DataEnterX_AAN
            // 
            DataEnterX_AAN.BackColor = SystemColors.ButtonFace;
            DataEnterX_AAN.BorderStyle = BorderStyle.None;
            DataEnterX_AAN.Font = new Font("Proxima Nova Th", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataEnterX_AAN.Location = new Point(76, 47);
            DataEnterX_AAN.Name = "DataEnterX_AAN";
            DataEnterX_AAN.ReadOnly = true;
            DataEnterX_AAN.Size = new Size(293, 24);
            DataEnterX_AAN.TabIndex = 7;
            DataEnterX_AAN.Text = "Введите значение переменной X";
            DataEnterX_AAN.TextChanged += textBox1_TextChanged_1;
            // 
            // TextBoxVarX
            // 
            TextBoxVarX.BackColor = SystemColors.Window;
            TextBoxVarX.Location = new Point(108, 84);
            TextBoxVarX.Name = "TextBoxVarX";
            TextBoxVarX.Size = new Size(216, 31);
            TextBoxVarX.TabIndex = 6;
            TextBoxVarX.KeyPress += TextBoxVarX_KeyPress;
            // 
            // ButtonStart_AAN
            // 
            ButtonStart_AAN.Location = new Point(624, 466);
            ButtonStart_AAN.Name = "ButtonStart_AAN";
            ButtonStart_AAN.Size = new Size(171, 41);
            ButtonStart_AAN.TabIndex = 3;
            ButtonStart_AAN.Text = "Выполнить";
            ButtonStart_AAN.UseVisualStyleBackColor = true;
            ButtonStart_AAN.Click += ButtonDone_Click;
            // 
            // ButtonQuestion_AAN
            // 
            ButtonQuestion_AAN.Location = new Point(543, 466);
            ButtonQuestion_AAN.Name = "ButtonQuestion_AAN";
            ButtonQuestion_AAN.Size = new Size(40, 41);
            ButtonQuestion_AAN.TabIndex = 4;
            ButtonQuestion_AAN.Text = "?";
            ButtonQuestion_AAN.UseVisualStyleBackColor = true;
            ButtonQuestion_AAN.Click += ButtonHelp_Click;
            // 
            // GroupBoxResult_AAN
            // 
            GroupBoxResult_AAN.BackgroundImageLayout = ImageLayout.None;
            GroupBoxResult_AAN.Controls.Add(TextBoxResult_AAN);
            GroupBoxResult_AAN.Font = new Font("Proxima Nova Cn Bl", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 204);
            GroupBoxResult_AAN.Location = new Point(543, 315);
            GroupBoxResult_AAN.Name = "GroupBoxResult_AAN";
            GroupBoxResult_AAN.Size = new Size(252, 133);
            GroupBoxResult_AAN.TabIndex = 5;
            GroupBoxResult_AAN.TabStop = false;
            GroupBoxResult_AAN.Text = "Вывод данных";
            // 
            // TextBoxResult_AAN
            // 
            TextBoxResult_AAN.Location = new Point(62, 84);
            TextBoxResult_AAN.Name = "TextBoxResult_AAN";
            TextBoxResult_AAN.ReadOnly = true;
            TextBoxResult_AAN.Size = new Size(135, 31);
            TextBoxResult_AAN.TabIndex = 0;
            TextBoxResult_AAN.TextChanged += ButtonDone_Click;
            // 
            // TextResult_AAN
            // 
            TextResult_AAN.BackColor = SystemColors.ButtonFace;
            TextResult_AAN.BorderStyle = BorderStyle.None;
            TextResult_AAN.Font = new Font("Proxima Nova Th", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextResult_AAN.Location = new Point(605, 362);
            TextResult_AAN.Name = "TextResult_AAN";
            TextResult_AAN.ReadOnly = true;
            TextResult_AAN.Size = new Size(100, 24);
            TextResult_AAN.TabIndex = 8;
            TextResult_AAN.Text = "Результат:";
            TextResult_AAN.TextChanged += textBox2_TextChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 545);
            Controls.Add(TextResult_AAN);
            Controls.Add(GroupBoxResult_AAN);
            Controls.Add(ButtonQuestion_AAN);
            Controls.Add(ButtonStart_AAN);
            Controls.Add(GroupBoxEnterX_AAN);
            Controls.Add(PictureBoxFormula_AAN);
            Controls.Add(GroupBox_AAN);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 0 | Вариант 11 | Абрамушкин А.Н.";
            Load += FormMain_Load;
            GroupBox_AAN.ResumeLayout(false);
            GroupBox_AAN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBoxFormula_AAN).EndInit();
            GroupBoxEnterX_AAN.ResumeLayout(false);
            GroupBoxEnterX_AAN.PerformLayout();
            GroupBoxResult_AAN.ResumeLayout(false);
            GroupBoxResult_AAN.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox GroupBox_AAN;
        private TextBox TextBox_AAN;
        private PictureBox PictureBoxFormula_AAN;
        private GroupBox GroupBoxEnterX_AAN;
        private Button ButtonStart_AAN;
        private Button ButtonQuestion_AAN;
        private GroupBox GroupBoxResult_AAN;
        private TextBox TextBoxVarX;
        private TextBox DataEnterX_AAN;
        private TextBox TextResult_AAN;
        private TextBox TextBoxResult_AAN;
        private ContextMenuStrip contextMenuStrip1;
    }
}
