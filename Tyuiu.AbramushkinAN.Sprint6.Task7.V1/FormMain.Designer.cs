namespace Tyuiu.AbramushkinAN.Sprint6.Task7.V1
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
            panelTools_AAN = new Panel();
            buttonAboutProgramm_AAN = new Button();
            buttonSaveFile_AAN = new Button();
            buttonDone_AAN = new Button();
            buttonOpenFile_AAN = new Button();
            panelCondition_AAN = new Panel();
            groupboxCondition_AAN = new GroupBox();
            textBoxCondition_AAN = new TextBox();
            panelInput_AAN = new Panel();
            groupBoxInput_AAN = new GroupBox();
            dataGridViewInput_AAN = new DataGridView();
            panelOutput_AAN = new Panel();
            groupBoxOutput_AAN = new GroupBox();
            dataGridViewOutput_AAN = new DataGridView();
            openFileDialogTask_AAN = new OpenFileDialog();
            saveFileDialogMatrix_AAN = new SaveFileDialog();
            toolTipButton_AAN = new ToolTip(components);
            panelTools_AAN.SuspendLayout();
            panelCondition_AAN.SuspendLayout();
            groupboxCondition_AAN.SuspendLayout();
            panelInput_AAN.SuspendLayout();
            groupBoxInput_AAN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInput_AAN).BeginInit();
            panelOutput_AAN.SuspendLayout();
            groupBoxOutput_AAN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput_AAN).BeginInit();
            SuspendLayout();
            // 
            // panelTools_AAN
            // 
            panelTools_AAN.Controls.Add(buttonAboutProgramm_AAN);
            panelTools_AAN.Controls.Add(buttonSaveFile_AAN);
            panelTools_AAN.Controls.Add(buttonDone_AAN);
            panelTools_AAN.Controls.Add(buttonOpenFile_AAN);
            panelTools_AAN.Dock = DockStyle.Top;
            panelTools_AAN.Location = new Point(0, 0);
            panelTools_AAN.Name = "panelTools_AAN";
            panelTools_AAN.Size = new Size(1184, 100);
            panelTools_AAN.TabIndex = 0;
            // 
            // buttonAboutProgramm_AAN
            // 
            buttonAboutProgramm_AAN.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAboutProgramm_AAN.BackColor = SystemColors.ControlLight;
            buttonAboutProgramm_AAN.Image = (Image)resources.GetObject("buttonAboutProgramm_AAN.Image");
            buttonAboutProgramm_AAN.Location = new Point(1050, 3);
            buttonAboutProgramm_AAN.Name = "buttonAboutProgramm_AAN";
            buttonAboutProgramm_AAN.Size = new Size(131, 91);
            buttonAboutProgramm_AAN.TabIndex = 3;
            toolTipButton_AAN.SetToolTip(buttonAboutProgramm_AAN, "Сведения о программе\r\n");
            buttonAboutProgramm_AAN.UseVisualStyleBackColor = false;
            buttonAboutProgramm_AAN.Click += buttonAboutProgramm_Click;
            buttonAboutProgramm_AAN.MouseEnter += buttonAboutProgramm_MouseEnter;
            // 
            // buttonSaveFile_AAN
            // 
            buttonSaveFile_AAN.BackColor = SystemColors.ControlLight;
            buttonSaveFile_AAN.Image = (Image)resources.GetObject("buttonSaveFile_AAN.Image");
            buttonSaveFile_AAN.Location = new Point(277, 3);
            buttonSaveFile_AAN.Name = "buttonSaveFile_AAN";
            buttonSaveFile_AAN.Size = new Size(131, 91);
            buttonSaveFile_AAN.TabIndex = 2;
            toolTipButton_AAN.SetToolTip(buttonSaveFile_AAN, "Сохранить обработанную матрицу в указанный файл\r\n");
            buttonSaveFile_AAN.UseVisualStyleBackColor = false;
            buttonSaveFile_AAN.Click += buttonSaveFile_Click;
            buttonSaveFile_AAN.MouseEnter += buttonSaveFile_MouseEnter;
            // 
            // buttonDone_AAN
            // 
            buttonDone_AAN.BackColor = SystemColors.ControlLight;
            buttonDone_AAN.Image = (Image)resources.GetObject("buttonDone_AAN.Image");
            buttonDone_AAN.Location = new Point(140, 3);
            buttonDone_AAN.Name = "buttonDone_AAN";
            buttonDone_AAN.Size = new Size(131, 91);
            buttonDone_AAN.TabIndex = 1;
            toolTipButton_AAN.SetToolTip(buttonDone_AAN, "Обработать файл по условию\r\n\r\n");
            buttonDone_AAN.UseVisualStyleBackColor = false;
            buttonDone_AAN.Click += buttonDone_Click;
            buttonDone_AAN.MouseEnter += buttonDone_MouseEnter;
            // 
            // buttonOpenFile_AAN
            // 
            buttonOpenFile_AAN.BackColor = SystemColors.ControlLight;
            buttonOpenFile_AAN.Image = (Image)resources.GetObject("buttonOpenFile_AAN.Image");
            buttonOpenFile_AAN.Location = new Point(3, 3);
            buttonOpenFile_AAN.Name = "buttonOpenFile_AAN";
            buttonOpenFile_AAN.Size = new Size(131, 91);
            buttonOpenFile_AAN.TabIndex = 0;
            toolTipButton_AAN.SetToolTip(buttonOpenFile_AAN, "Выберите файл для обработки\r\n");
            buttonOpenFile_AAN.UseVisualStyleBackColor = false;
            buttonOpenFile_AAN.Click += buttonOpenFile_Click;
            buttonOpenFile_AAN.MouseEnter += buttonOpenFile_MouseEnter;
            // 
            // panelCondition_AAN
            // 
            panelCondition_AAN.Controls.Add(groupboxCondition_AAN);
            panelCondition_AAN.Dock = DockStyle.Top;
            panelCondition_AAN.Location = new Point(0, 100);
            panelCondition_AAN.Name = "panelCondition_AAN";
            panelCondition_AAN.Size = new Size(1184, 89);
            panelCondition_AAN.TabIndex = 1;
            // 
            // groupboxCondition_AAN
            // 
            groupboxCondition_AAN.Controls.Add(textBoxCondition_AAN);
            groupboxCondition_AAN.Dock = DockStyle.Fill;
            groupboxCondition_AAN.Location = new Point(0, 0);
            groupboxCondition_AAN.Name = "groupboxCondition_AAN";
            groupboxCondition_AAN.Size = new Size(1184, 89);
            groupboxCondition_AAN.TabIndex = 0;
            groupboxCondition_AAN.TabStop = false;
            groupboxCondition_AAN.Text = "Условие:";
            // 
            // textBoxCondition_AAN
            // 
            textBoxCondition_AAN.BackColor = SystemColors.Control;
            textBoxCondition_AAN.BorderStyle = BorderStyle.None;
            textBoxCondition_AAN.Dock = DockStyle.Fill;
            textBoxCondition_AAN.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxCondition_AAN.Location = new Point(3, 19);
            textBoxCondition_AAN.Multiline = true;
            textBoxCondition_AAN.Name = "textBoxCondition_AAN";
            textBoxCondition_AAN.Size = new Size(1178, 67);
            textBoxCondition_AAN.TabIndex = 0;
            textBoxCondition_AAN.Text = resources.GetString("textBoxCondition_AAN.Text");
            // 
            // panelInput_AAN
            // 
            panelInput_AAN.Controls.Add(groupBoxInput_AAN);
            panelInput_AAN.Dock = DockStyle.Left;
            panelInput_AAN.Location = new Point(0, 189);
            panelInput_AAN.Name = "panelInput_AAN";
            panelInput_AAN.Size = new Size(584, 372);
            panelInput_AAN.TabIndex = 2;
            // 
            // groupBoxInput_AAN
            // 
            groupBoxInput_AAN.Controls.Add(dataGridViewInput_AAN);
            groupBoxInput_AAN.Dock = DockStyle.Left;
            groupBoxInput_AAN.Location = new Point(0, 0);
            groupBoxInput_AAN.Name = "groupBoxInput_AAN";
            groupBoxInput_AAN.Size = new Size(584, 372);
            groupBoxInput_AAN.TabIndex = 0;
            groupBoxInput_AAN.TabStop = false;
            groupBoxInput_AAN.Text = "Ввод:";
            // 
            // dataGridViewInput_AAN
            // 
            dataGridViewInput_AAN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInput_AAN.Dock = DockStyle.Fill;
            dataGridViewInput_AAN.Location = new Point(3, 19);
            dataGridViewInput_AAN.Name = "dataGridViewInput_AAN";
            dataGridViewInput_AAN.Size = new Size(578, 350);
            dataGridViewInput_AAN.TabIndex = 0;
            // 
            // panelOutput_AAN
            // 
            panelOutput_AAN.Controls.Add(groupBoxOutput_AAN);
            panelOutput_AAN.Dock = DockStyle.Fill;
            panelOutput_AAN.Location = new Point(584, 189);
            panelOutput_AAN.Name = "panelOutput_AAN";
            panelOutput_AAN.Size = new Size(600, 372);
            panelOutput_AAN.TabIndex = 3;
            // 
            // groupBoxOutput_AAN
            // 
            groupBoxOutput_AAN.Controls.Add(dataGridViewOutput_AAN);
            groupBoxOutput_AAN.Dock = DockStyle.Fill;
            groupBoxOutput_AAN.Location = new Point(0, 0);
            groupBoxOutput_AAN.Name = "groupBoxOutput_AAN";
            groupBoxOutput_AAN.Size = new Size(600, 372);
            groupBoxOutput_AAN.TabIndex = 0;
            groupBoxOutput_AAN.TabStop = false;
            groupBoxOutput_AAN.Text = "Вывод:";
            // 
            // dataGridViewOutput_AAN
            // 
            dataGridViewOutput_AAN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutput_AAN.Dock = DockStyle.Fill;
            dataGridViewOutput_AAN.Location = new Point(3, 19);
            dataGridViewOutput_AAN.Name = "dataGridViewOutput_AAN";
            dataGridViewOutput_AAN.Size = new Size(594, 350);
            dataGridViewOutput_AAN.TabIndex = 0;
            // 
            // openFileDialogTask_AAN
            // 
            openFileDialogTask_AAN.FileName = "openFileDialog1";
            // 
            // toolTipButton_AAN
            // 
            toolTipButton_AAN.ToolTipIcon = ToolTipIcon.Info;
            // 
            // FormMain_AAN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 561);
            Controls.Add(panelOutput_AAN);
            Controls.Add(panelInput_AAN);
            Controls.Add(panelCondition_AAN);
            Controls.Add(panelTools_AAN);
            MinimumSize = new Size(1200, 600);
            Name = "FormMain_AAN";
            Text = "Спринт 6 | Таск 7 | Вариант 1 | Абрамушкин А.Н.";
            panelTools_AAN.ResumeLayout(false);
            panelCondition_AAN.ResumeLayout(false);
            groupboxCondition_AAN.ResumeLayout(false);
            groupboxCondition_AAN.PerformLayout();
            panelInput_AAN.ResumeLayout(false);
            groupBoxInput_AAN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInput_AAN).EndInit();
            panelOutput_AAN.ResumeLayout(false);
            groupBoxOutput_AAN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput_AAN).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTools_AAN;
        private Button buttonAboutProgramm_AAN;
        private Button buttonSaveFile_AAN;
        private Button buttonDone_AAN;
        private Button buttonOpenFile_AAN;
        private Panel panelCondition_AAN;
        private GroupBox groupboxCondition_AAN;
        private TextBox textBoxCondition_AAN;
        private Panel panelInput_AAN;
        private GroupBox groupBoxInput_AAN;
        private DataGridView dataGridViewInput_AAN;
        private Panel panelOutput_AAN;
        private GroupBox groupBoxOutput_AAN;
        private DataGridView dataGridViewOutput_AAN;
        private ToolTip toolTipButton_AAN;
        private OpenFileDialog openFileDialogTask_AAN;
        private SaveFileDialog saveFileDialogMatrix_AAN;
    }
}
