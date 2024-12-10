using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.AbramushkinAN.Sprint6.Task6.V11.Lib
{
    public class DataService : ISprint6Task6V11
    {
        public string CollectTextFromFile(string path)
        {
            string resstr = "";

            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] array = line.Split(" ");
                    Array.Reverse(array);
                    resstr += array[1];
                }

            }

            return resstr;
        }

    }
}