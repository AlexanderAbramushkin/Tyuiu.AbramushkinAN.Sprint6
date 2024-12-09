using Tyuiu.AbramushkinAN.Sprint6.Task1.V15.Lib;

namespace Tyuiu.AbramushkinAN.Sprint6.Task1.V15
{
    public partial class FormMain_AAN : Form
    {
        public FormMain_AAN()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TextBoxCondition_AAN_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ИИПб-24-2 Абрамушкин Александр Николаевич");
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxOutputResult_AAN_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonLaunch_AAN_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(TextBoxStartStepInput_AAN.Text);
                int stopStep = Convert.ToInt32(TextBoxStopStepInput_AAN.Text);

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);

                TextBoxOutputResult_AAN.Text = "";
                TextBoxOutputResult_AAN.AppendText("+------+------+" + Environment.NewLine);
                TextBoxOutputResult_AAN.AppendText("|    X     |   f(x)   |" + Environment.NewLine);
                TextBoxOutputResult_AAN.AppendText("+------+------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}     |  {1, 5:f2}    |", startStep, valueArray[i]);
                    TextBoxOutputResult_AAN.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }
                TextBoxOutputResult_AAN.AppendText("+------+------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены некорректные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

