namespace Tyuiu.AbramushkinAN.Sprint6.Task7.V1
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            buttonOK_AAN = new Button();
            pictureBoxPhoto_AAN = new PictureBox();
            textBoxAboutProgramm_AAN = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPhoto_AAN).BeginInit();
            SuspendLayout();
            // 
            // buttonOK_AAN
            // 
            buttonOK_AAN.Location = new Point(479, 234);
            buttonOK_AAN.Name = "buttonOK_AAN";
            buttonOK_AAN.Size = new Size(72, 29);
            buttonOK_AAN.TabIndex = 0;
            buttonOK_AAN.Text = "Ок";
            buttonOK_AAN.UseVisualStyleBackColor = true;
            buttonOK_AAN.Click += buttonOK_AAN_Click;
            // 
            // pictureBoxPhoto_AAN
            // 
            pictureBoxPhoto_AAN.Image = (Image)resources.GetObject("pictureBoxPhoto_AAN.Image");
            pictureBoxPhoto_AAN.Location = new Point(12, 12);
            pictureBoxPhoto_AAN.Name = "pictureBoxPhoto_AAN";
            pictureBoxPhoto_AAN.Size = new Size(166, 251);
            pictureBoxPhoto_AAN.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPhoto_AAN.TabIndex = 1;
            pictureBoxPhoto_AAN.TabStop = false;
            // 
            // textBoxAboutProgramm_AAN
            // 
            textBoxAboutProgramm_AAN.BackColor = SystemColors.Control;
            textBoxAboutProgramm_AAN.BorderStyle = BorderStyle.None;
            textBoxAboutProgramm_AAN.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxAboutProgramm_AAN.Location = new Point(210, 12);
            textBoxAboutProgramm_AAN.Multiline = true;
            textBoxAboutProgramm_AAN.Name = "textBoxAboutProgramm_AAN";
            textBoxAboutProgramm_AAN.Size = new Size(341, 216);
            textBoxAboutProgramm_AAN.TabIndex = 2;
            textBoxAboutProgramm_AAN.Text = resources.GetString("textBoxAboutProgramm_AAN.Text");
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(563, 275);
            Controls.Add(textBoxAboutProgramm_AAN);
            Controls.Add(pictureBoxPhoto_AAN);
            Controls.Add(buttonOK_AAN);
            MaximumSize = new Size(579, 314);
            Name = "FormAbout";
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxPhoto_AAN).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOK_AAN;
        private PictureBox pictureBoxPhoto_AAN;
        private TextBox textBoxAboutProgramm_AAN;
    }
}