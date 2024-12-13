using System.Windows.Forms;

namespace Tyuiu.AbramushkinAN.Sprint6.Task6.V11
{
    partial class FormAbout_AAN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout_AAN));
            buttonClose_AAN = new Button();
            pictureBoxphoto_AAN = new PictureBox();
            textBoxAbout_AAN = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxphoto_AAN).BeginInit();
            SuspendLayout();
            // 
            // buttonClose_AAN
            // 
            buttonClose_AAN.Location = new Point(483, 238);
            buttonClose_AAN.Name = "buttonClose_AAN";
            buttonClose_AAN.Size = new Size(78, 34);
            buttonClose_AAN.TabIndex = 0;
            buttonClose_AAN.Text = "Ок";
            buttonClose_AAN.UseVisualStyleBackColor = true;
            buttonClose_AAN.Click += buttonClose_Click;
            // 
            // pictureBoxphoto_AAN
            // 
            pictureBoxphoto_AAN.Image = (Image)resources.GetObject("pictureBoxphoto_AAN.Image");
            pictureBoxphoto_AAN.Location = new Point(12, 12);
            pictureBoxphoto_AAN.Name = "pictureBoxphoto_AAN";
            pictureBoxphoto_AAN.Size = new Size(151, 220);
            pictureBoxphoto_AAN.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxphoto_AAN.TabIndex = 1;
            pictureBoxphoto_AAN.TabStop = false;
            // 
            // textBoxAbout_AAN
            // 
            textBoxAbout_AAN.BackColor = SystemColors.Control;
            textBoxAbout_AAN.BorderStyle = BorderStyle.None;
            textBoxAbout_AAN.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxAbout_AAN.Location = new Point(169, 12);
            textBoxAbout_AAN.Multiline = true;
            textBoxAbout_AAN.Name = "textBoxAbout_AAN";
            textBoxAbout_AAN.Size = new Size(392, 220);
            textBoxAbout_AAN.TabIndex = 2;
            textBoxAbout_AAN.Text = resources.GetString("textBoxAbout_AAN.Text");
            // 
            // FormAbout_AAN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(563, 275);
            Controls.Add(textBoxAbout_AAN);
            Controls.Add(pictureBoxphoto_AAN);
            Controls.Add(buttonClose_AAN);
            Name = "FormAbout_AAN";
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxphoto_AAN).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonClose_AAN;
        private PictureBox pictureBoxphoto_AAN;
        private TextBox textBoxAbout_AAN;
    }
}