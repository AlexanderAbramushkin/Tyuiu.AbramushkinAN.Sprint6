using Tyuiu.AbramushkinAN.Sprint6.Task4.V19.Lib;

namespace Tyuiu.AbramushkinAN.Sprint6.Task4.V19
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
        private void buttonStart_AAN_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxInputStart_AAN.Text);
                int stopStep = Convert.ToInt32(textBoxInputStop_AAN.Text);

                double[] valueArray = ds.GetMassFunction(startStep, stopStep);
                int index = 0;

                this.chartFunction_AAN.Titles.Add("������ �������");
                this.chartFunction_AAN.ChartAreas[0].AxisX.Title = "��� X";
                this.chartFunction_AAN.ChartAreas[0].AxisY.Title = "��� Y";
                for (int i = startStep; i <= stopStep; i++)
                {

                    textBoxResult_AAN.AppendText(valueArray[index] + Environment.NewLine);

                    this.chartFunction_AAN.Series[0].Points.AddXY(i, valueArray[index]);
                    index++;
                }
            }
            catch
            {
                MessageBox.Show("������� �������� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonSave_AAN_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask4V19.txt");
                File.WriteAllText(path, textBoxResult_AAN.Text);

                DialogResult dialogresult = MessageBox.Show($"���� {path} ������� �������\n ������� ��� � ��������?", "���������� �����", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogresult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }    
            }
            catch
            {
                MessageBox.Show("���� ��� ��������� �����", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonHelp_AAN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���� 4 �������� ������� ����-24-2 ���������� ��������� ����������", "�������", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
