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
                int startStep = Convert.ToInt32(TextBoxInputStartStep_AAN.Text);
                int stopStep = Convert.ToInt32(TextBoxInputStopStep_AAN.Text);

                double[] valueArray = ds.GetMassFunction(startStep, stopStep);
                int index = 0;

                this.ChartFunction_AAN.Titles.Add("График функции");
                this.ChartFunction_AAN.ChartAreas[0].AxisX.Title = "Ось X";
                this.ChartFunction_AAN.ChartAreas[0].AxisY.Title = "Ось Y";
                for (int i = startStep; i <= stopStep; i++)
                {
                    
                    this.dataGridViewFunction_AAN.Rows.Add(i, valueArray[index]);

                    this.ChartFunction_AAN.Series[0].Points.AddXY(i, valueArray[index]);
                    index++;
                }
            }
            catch
            {
                MessageBox.Show("Введены некорректные данные","Ошибка",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ButtonHelp(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ИИПб-24-2 Абрамушкин Александр Николаевич");
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
