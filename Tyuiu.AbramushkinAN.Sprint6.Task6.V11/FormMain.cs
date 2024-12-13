using System.IO;
using Tyuiu.AbramushkinAN.Sprint6.Task6.V11.Lib;

namespace Tyuiu.AbramushkinAN.Sprint6.Task6.V11
{
    public partial class FormMain_AAN : Form
    {
        public FormMain_AAN()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();
        private void FormMain_AAN_Load(object sender, EventArgs e)
        {
            buttonDone_AAN.Enabled = false;
        }
        private void buttonDone_Click(object sender, EventArgs e)
        {
            textBoxOutput_AAN.Text = ds.CollectTextFromFile(openFilePath);
        }
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormAbout_AAN formAbout = new FormAbout_AAN();
            formAbout.ShowDialog();
        }
        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialogTask_AAN.ShowDialog();
            openFilePath = openFileDialogTask_AAN.FileName;
            textBoxInput_AAN.Text = File.ReadAllText(openFilePath);
            groupBoxInput_AAN.Text = groupBoxInput_AAN.Text + " " + openFileDialogTask_AAN.FileName;
            buttonDone_AAN.Enabled = true;
        }

        private void groupBoxOutput_AAN_Enter(object sender, EventArgs e)
        {

        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void panelUp_AAN_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelInput_AAN_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxInput_AAN_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
