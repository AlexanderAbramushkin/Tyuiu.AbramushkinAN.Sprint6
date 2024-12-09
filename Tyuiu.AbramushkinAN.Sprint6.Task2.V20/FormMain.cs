using Tyuiu.AbramushkinAN.Sprint6.Task2.V20.Lib;

namespace Tyuiu.AbramushkinAN.Sprint6.Task2.V20
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void ButtonStart(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(TextBoxInputStartStep_AAN);
                int stopStep = Convert.ToInt32(TextBoxInputStopStep_AAN);


                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.ChartFunction_AAN.Titles.Add("������ �������");
                this.ChartFunction_AAN.ChartAreas[0].AxisX.Title = "��� X";
                this.ChartFunction_AAN.ChartAreas[0].AxisY.Title = "��� Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction_AAN.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));

                    this.ChartFunction_AAN.Series[0].Points.AddXY(startStep, valueArray[i]);

                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("������� ������������ ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ButtonHelp(object sender, EventArgs e)
        {
            MessageBox.Show("���� 2 �������� ������� ������ ����-24-2 ���������� ��������� ����������");
        }
        private void ButtonStart_MouseEnter(object sender, EventArgs e)
        {
            ButtonStart_AAN.BackColor = Color.Red;
        }
        private void ButtonHelp_MouseEnter(object sender, EventArgs e)
        {
            ButtonHelp_AAN.BackColor = Color.Blue;
        }
        private void ButtonStart_MouseLeave(object sender, EventArgs e)
        {
            ButtonStart_AAN.BackColor = Color.LimeGreen;
        }
        private void ButtonHelp_MouseLeave(object sender, EventArgs e)
        {
            ButtonHelp_AAN.BackColor = Color.MediumSlateBlue;
        }

    }
} 
