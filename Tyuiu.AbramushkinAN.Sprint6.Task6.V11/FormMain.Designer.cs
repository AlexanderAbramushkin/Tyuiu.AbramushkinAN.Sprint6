namespace Tyuiu.AbramushkinAN.Sprint6.Task6.V11
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_AAN));
            groupBoxCondition_AAN = new GroupBox();
            textBox_Condition_AAN = new TextBox();
            buttonOpenFile_AAN = new Button();
            buttonDone_AAN = new Button();
            buttonHelp_AAN = new Button();
            groupBoxInput_AAN = new GroupBox();
            textBoxInput_AAN = new TextBox();
            groupBoxOutput_AAN = new GroupBox();
            splitterInputOutput_AAN = new Splitter();
            textBoxOutput_AAN = new TextBox();
            openFileDialogTask_AAN = new OpenFileDialog();
            toolTipTask_AAN = new ToolTip(components);
            panelUp_AAN = new Panel();
            panelInput_AAN = new Panel();
            panelOutput_AAN = new Panel();
            panel1 = new Panel();
            panelCondition_AAN = new Panel();
            groupBoxCondition_AAN.SuspendLayout();
            groupBoxInput_AAN.SuspendLayout();
            groupBoxOutput_AAN.SuspendLayout();
            panelUp_AAN.SuspendLayout();
            panelInput_AAN.SuspendLayout();
            panelOutput_AAN.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCondition_AAN
            // 
            groupBoxCondition_AAN.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxCondition_AAN.Controls.Add(textBox_Condition_AAN);
            groupBoxCondition_AAN.FlatStyle = FlatStyle.Popup;
            groupBoxCondition_AAN.Location = new Point(3, 3);
            groupBoxCondition_AAN.Name = "groupBoxCondition_AAN";
            groupBoxCondition_AAN.Size = new Size(1419, 101);
            groupBoxCondition_AAN.TabIndex = 0;
            groupBoxCondition_AAN.TabStop = false;
            groupBoxCondition_AAN.Text = "Условие:";
            // 
            // textBox_Condition_AAN
            // 
            textBox_Condition_AAN.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_Condition_AAN.BackColor = SystemColors.Control;
            textBox_Condition_AAN.BorderStyle = BorderStyle.None;
            textBox_Condition_AAN.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox_Condition_AAN.Location = new Point(6, 22);
            textBox_Condition_AAN.Multiline = true;
            textBox_Condition_AAN.Name = "textBox_Condition_AAN";
            textBox_Condition_AAN.ReadOnly = true;
            textBox_Condition_AAN.Size = new Size(1389, 68);
            textBox_Condition_AAN.TabIndex = 0;
            textBox_Condition_AAN.Text = resources.GetString("textBox_Condition_AAN.Text");
            // 
            // buttonOpenFile_AAN
            // 
            buttonOpenFile_AAN.Image = (Image)resources.GetObject("buttonOpenFile_AAN.Image");
            buttonOpenFile_AAN.Location = new Point(12, 12);
            buttonOpenFile_AAN.Name = "buttonOpenFile_AAN";
            buttonOpenFile_AAN.Padding = new Padding(100);
            buttonOpenFile_AAN.Size = new Size(119, 85);
            buttonOpenFile_AAN.TabIndex = 1;
            toolTipTask_AAN.SetToolTip(buttonOpenFile_AAN, "Открыть файл\r\nВыберите нужный файл для обработки\r\n");
            buttonOpenFile_AAN.UseVisualStyleBackColor = true;
            buttonOpenFile_AAN.Click += buttonOpenFile_Click;
            // 
            // buttonDone_AAN
            // 
            buttonDone_AAN.Image = (Image)resources.GetObject("buttonDone_AAN.Image");
            buttonDone_AAN.Location = new Point(137, 12);
            buttonDone_AAN.Name = "buttonDone_AAN";
            buttonDone_AAN.Size = new Size(119, 85);
            buttonDone_AAN.TabIndex = 2;
            toolTipTask_AAN.SetToolTip(buttonDone_AAN, "Запустить программу\r\nВывод предпоследнего слова каждой строки");
            buttonDone_AAN.UseVisualStyleBackColor = true;
            buttonDone_AAN.Click += buttonDone_Click;
            // 
            // buttonHelp_AAN
            // 
            buttonHelp_AAN.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_AAN.Image = (Image)resources.GetObject("buttonHelp_AAN.Image");
            buttonHelp_AAN.Location = new Point(1303, 12);
            buttonHelp_AAN.Name = "buttonHelp_AAN";
            buttonHelp_AAN.Size = new Size(119, 85);
            buttonHelp_AAN.TabIndex = 3;
            toolTipTask_AAN.SetToolTip(buttonHelp_AAN, "Сведения о программе");
            buttonHelp_AAN.UseVisualStyleBackColor = true;
            buttonHelp_AAN.Click += buttonHelp_Click;
            // 
            // groupBoxInput_AAN
            // 
            groupBoxInput_AAN.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            groupBoxInput_AAN.Controls.Add(textBoxInput_AAN);
            groupBoxInput_AAN.Location = new Point(6, 2);
            groupBoxInput_AAN.Name = "groupBoxInput_AAN";
            groupBoxInput_AAN.Size = new Size(614, 590);
            groupBoxInput_AAN.TabIndex = 4;
            groupBoxInput_AAN.TabStop = false;
            groupBoxInput_AAN.Text = "Ввод:";
            // 
            // textBoxInput_AAN
            // 
            textBoxInput_AAN.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxInput_AAN.BackColor = SystemColors.ButtonHighlight;
            textBoxInput_AAN.BorderStyle = BorderStyle.None;
            textBoxInput_AAN.Location = new Point(12, 16);
            textBoxInput_AAN.Multiline = true;
            textBoxInput_AAN.Name = "textBoxInput_AAN";
            textBoxInput_AAN.ReadOnly = true;
            textBoxInput_AAN.ScrollBars = ScrollBars.Vertical;
            textBoxInput_AAN.Size = new Size(596, 560);
            textBoxInput_AAN.TabIndex = 0;
            textBoxInput_AAN.TextChanged += textBoxInput_AAN_TextChanged;
            // 
            // groupBoxOutput_AAN
            // 
            groupBoxOutput_AAN.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            groupBoxOutput_AAN.Controls.Add(splitterInputOutput_AAN);
            groupBoxOutput_AAN.Controls.Add(textBoxOutput_AAN);
            groupBoxOutput_AAN.Location = new Point(0, 2);
            groupBoxOutput_AAN.Margin = new Padding(50);
            groupBoxOutput_AAN.Name = "groupBoxOutput_AAN";
            groupBoxOutput_AAN.Size = new Size(758, 593);
            groupBoxOutput_AAN.TabIndex = 5;
            groupBoxOutput_AAN.TabStop = false;
            groupBoxOutput_AAN.Text = "Вывод:";
            groupBoxOutput_AAN.Enter += groupBoxOutput_AAN_Enter;
            // 
            // splitterInputOutput_AAN
            // 
            splitterInputOutput_AAN.Location = new Point(3, 19);
            splitterInputOutput_AAN.Name = "splitterInputOutput_AAN";
            splitterInputOutput_AAN.Size = new Size(10, 571);
            splitterInputOutput_AAN.TabIndex = 2;
            splitterInputOutput_AAN.TabStop = false;
            // 
            // textBoxOutput_AAN
            // 
            textBoxOutput_AAN.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBoxOutput_AAN.BackColor = SystemColors.ButtonHighlight;
            textBoxOutput_AAN.BorderStyle = BorderStyle.None;
            textBoxOutput_AAN.Location = new Point(6, 19);
            textBoxOutput_AAN.Multiline = true;
            textBoxOutput_AAN.Name = "textBoxOutput_AAN";
            textBoxOutput_AAN.ReadOnly = true;
            textBoxOutput_AAN.ScrollBars = ScrollBars.Vertical;
            textBoxOutput_AAN.Size = new Size(746, 546);
            textBoxOutput_AAN.TabIndex = 1;
            // 
            // openFileDialogTask_AAN
            // 
            openFileDialogTask_AAN.FileName = "openFileDialog1";
            // 
            // toolTipTask_AAN
            // 
            toolTipTask_AAN.ToolTipIcon = ToolTipIcon.Info;
            toolTipTask_AAN.ToolTipTitle = "Подсказка";
            // 
            // panelUp_AAN
            // 
            panelUp_AAN.Anchor = AnchorStyles.Top;
            panelUp_AAN.Controls.Add(buttonDone_AAN);
            panelUp_AAN.Controls.Add(panelCondition_AAN);
            panelUp_AAN.Location = new Point(0, 0);
            panelUp_AAN.Name = "panelUp_AAN";
            panelUp_AAN.Size = new Size(1433, 104);
            panelUp_AAN.TabIndex = 1;
            panelUp_AAN.Paint += panelUp_AAN_Paint;
            // 
            // panelInput_AAN
            // 
            panelInput_AAN.AutoSize = true;
            panelInput_AAN.Controls.Add(groupBoxInput_AAN);
            panelInput_AAN.Location = new Point(12, 216);
            panelInput_AAN.Name = "panelInput_AAN";
            panelInput_AAN.Size = new Size(633, 731);
            panelInput_AAN.TabIndex = 6;
            panelInput_AAN.Paint += panelInput_AAN_Paint;
            // 
            // panelOutput_AAN
            // 
            panelOutput_AAN.Controls.Add(groupBoxOutput_AAN);
            panelOutput_AAN.Location = new Point(651, 216);
            panelOutput_AAN.Name = "panelOutput_AAN";
            panelOutput_AAN.Size = new Size(771, 607);
            panelOutput_AAN.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBoxCondition_AAN);
            panel1.Location = new Point(0, 103);
            panel1.Name = "panel1";
            panel1.Size = new Size(1433, 109);
            panel1.TabIndex = 8;
            // 
            // panelCondition_AAN
            // 
            panelCondition_AAN.AccessibleRole = AccessibleRole.TitleBar;
            panelCondition_AAN.Anchor = AnchorStyles.Top;
            panelCondition_AAN.Location = new Point(0, 103);
            panelCondition_AAN.Name = "panelCondition_AAN";
            panelCondition_AAN.Size = new Size(1421, 107);
            panelCondition_AAN.TabIndex = 1;
            // 
            // FormMain_AAN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1433, 835);
            Controls.Add(panel1);
            Controls.Add(panelOutput_AAN);
            Controls.Add(panelInput_AAN);
            Controls.Add(buttonOpenFile_AAN);
            Controls.Add(buttonHelp_AAN);
            Controls.Add(panelUp_AAN);
            MinimumSize = new Size(1449, 874);
            Name = "FormMain_AAN";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 6 | Вариант 11 | Абрамушкин А.Н.";
            Load += FormMain_AAN_Load;
            groupBoxCondition_AAN.ResumeLayout(false);
            groupBoxCondition_AAN.PerformLayout();
            groupBoxInput_AAN.ResumeLayout(false);
            groupBoxInput_AAN.PerformLayout();
            groupBoxOutput_AAN.ResumeLayout(false);
            groupBoxOutput_AAN.PerformLayout();
            panelUp_AAN.ResumeLayout(false);
            panelInput_AAN.ResumeLayout(false);
            panelOutput_AAN.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxCondition_AAN;
        private TextBox textBox_Condition_AAN;
        private Button buttonOpenFile_AAN;
        private Button buttonDone_AAN;
        private Button buttonHelp_AAN;
        private GroupBox groupBoxInput_AAN;
        private TextBox textBoxInput_AAN;
        private GroupBox groupBoxOutput_AAN;
        private TextBox textBoxOutput_AAN;
        private ToolTip toolTipTask_AAN;
        private OpenFileDialog openFileDialogTask_AAN;
        private Panel panelUp_AAN;
        private Splitter splitterInputOutput_AAN;
        private Panel panelInput_AAN;
        private Panel panelOutput_AAN;
        private Panel panelCondition_AAN;
        private Panel panel1;
    }
}
