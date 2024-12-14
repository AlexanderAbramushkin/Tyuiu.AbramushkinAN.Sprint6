using Tyuiu.AbramushkinAN.Sprint6.Task7.V1.Lib;
using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.AbramushkinAN.Sprint6.Task7.V1
{
    public partial class FormMain_AAN : Form
    {
        public FormMain_AAN()
        {
            InitializeComponent();
            buttonDone_AAN.Enabled = false;
            buttonSaveFile_AAN.Enabled = false;
            openFileDialogTask_AAN.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_AAN.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";

        }
        DataService ds = new DataService();
        static int columns;
        static int rows;
        string openFilePath = "";
        public static int[,] LoadFromDataFile(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            rows = lines.Length;
            columns = lines[0].Split(';').Length;
            int[,] arrayValues = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line_r = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    arrayValues[i, j] = Convert.ToInt32(line_r[j]);
                }
            }
            return arrayValues;
        }
        private void buttonAboutProgramm_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
        private void buttonDone_Click(object sender, EventArgs e)
        {
            int[,] arrayResult = ds.GetMatrix(openFilePath);
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOutput_AAN.Rows[r].Cells[c].Value = arrayResult[r,c];
                }
            }
            buttonSaveFile_AAN.Enabled = true;
        }
        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_AAN.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_AAN.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_AAN.ShowDialog();
            string path = saveFileDialogMatrix_AAN.FileName;
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists) 
            {
                File.Delete(path);
            }
            int rows = dataGridViewOutput_AAN.RowCount;
            int columns = dataGridViewOutput_AAN.ColumnCount;

            string str = "";
            for (int r = 0;r < rows; r++)
            {
                for(int c = 0;c < columns; c++)
                {
                    if (c != columns - 1)
                    {
                        str += dataGridViewOutput_AAN.Rows[r].Cells[c].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewOutput_AAN.Rows[r].Cells[c].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }




        }
        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialogTask_AAN.ShowDialog();
            string openFilePath = openFileDialogTask_AAN.FileName;

            int[,] arrayValues = new int[rows,columns];

            arrayValues = LoadFromDataFile(openFilePath);
            dataGridViewInput_AAN.ColumnCount = columns;
            dataGridViewInput_AAN.RowCount = rows;
            dataGridViewOutput_AAN.ColumnCount = columns;
            dataGridViewOutput_AAN.RowCount = rows;

            for (int i = 0; i<columns; i++)
            {
                dataGridViewInput_AAN.Columns[i].Width = 25;
                dataGridViewOutput_AAN.Columns[i].Width = 25;
            }
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewInput_AAN.Rows[r].Cells[c].Value = arrayValues[r,c];
                }
            }
            buttonDone_AAN.Enabled = true;
        }
        private void buttonOpenFile_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_AAN.ToolTipTitle = "Открыть файл";
        }
        private void buttonDone_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_AAN.ToolTipTitle = "Запустить программу";
        }
        private void buttonSaveFile_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_AAN.ToolTipTitle = "Сохранить в файл";
        }
        private void buttonAboutProgramm_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_AAN.ToolTipTitle = "О программе";
        }

    }
}
