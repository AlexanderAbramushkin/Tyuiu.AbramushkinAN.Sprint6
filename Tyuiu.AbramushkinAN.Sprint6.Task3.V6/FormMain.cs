using Tyuiu.AbramushkinAN.Sprint6.Task3.V6.Lib;

namespace Tyuiu.AbramushkinAN.Sprint6.Task3.V6
{
    public partial class FormMain_AAN : Form
    {
        public FormMain_AAN()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        int[,] mtrx = new int[5, 5]   { { -2, -10, -8, 11, 1 },
                                             { -15,-9,-4,-15,18   },
                                             { -15, 12, 7 ,6 , 9   },
                                             { -14, -10, 10, 18, -5 },
                                             { -1, 7, -19, -19, -4}};


        private void TextBoxCondition_AAN_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormMain_AAN_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            MatrixInput_AAN.ColumnCount = columns;
            MatrixInput_AAN.RowCount = rows;
            for (int i = 0; i < columns; i++)
            {
                MatrixInput_AAN.Columns[i].Width = 50;
            }


            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    MatrixInput_AAN.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }
        private void ButtonStart_Click(object sender, EventArgs e)
        {

            int[,] newmtrx = ds.Calculate(mtrx);
            int newrows = newmtrx.GetUpperBound(0) + 1;
            int newcolumns = newmtrx.Length / newrows;

            MatrixOutput_AAN.ColumnCount = newcolumns;
            MatrixOutput_AAN.RowCount = newrows;
            for (int i = 0; i < newcolumns; i++)
            {
                MatrixOutput_AAN.Columns[i].Width = 50;
            }


            for (int i = 0; i < newcolumns; i++)
            {
                for (int j = 0; j < newrows; j++)
                {
                    MatrixOutput_AAN.Rows[i].Cells[j].Value = Convert.ToString(newmtrx[i, j]);
                }
            }
        }
        private void ButtonHelp_Click(object sender, EventArgs e)
        {
        MessageBox.Show("Таск 3 выполнил студент ИИПб-24-2 Абрамушкин Александр Николаевич");
        }
    }
}
