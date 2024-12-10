using Tyuiu.AbramushkinAN.Sprint6.Task5.V1.Lib;

namespace Tyuiu.AbramushkinAN.Sprint6.Task5.V1
{
    public partial class FormMain_AAN : Form
    {
        public FormMain_AAN()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        string path = @"C:\Users\User\Desktop\DataSprint6\InPutDataFileTask5V1.txt";
        private void buttonDone_AAN_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewResult_AAN.ColumnCount = 2;
                dataGridViewResult_AAN.Columns[0].Width = 20;
                dataGridViewResult_AAN.Columns[1].Width = 50;

                this.chartFunction_AAN.Titles.Add("График функции");
                this.chartFunction_AAN.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_AAN.ChartAreas[0].AxisY.Title = "Ось Y";

                chartFunction_AAN.Series[0].Points.Clear();

                double[] numsMass = ds.LoadFromDataFile(path);

                
                for (int i = 0; i < numsMass.Length; i++)
                {

                    dataGridViewResult_AAN.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));

                    chartFunction_AAN.Series[0].Points.AddXY(i, numsMass[i]);
                }
            }
            catch
            {
                MessageBox.Show("Файл не найден/Ошибка в данных файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonOpen_AAN_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_AAN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент ИИПб-24-2 Абрамушкин Александр Николаевич", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
