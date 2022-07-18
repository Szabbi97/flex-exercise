using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flex_exercise
{
    internal class Program
    {
        static readonly string textFile = "input.txt";
        static void Main(string[] args)
        {
            List<DataRow> DataRowList = new List<DataRow>();
            if (File.Exists(textFile))
            {
                using (StreamReader file = new StreamReader(textFile))
                {
                    int counter = 0;
                    string ln;

                    while ((ln = file.ReadLine()) != null)
                    {
                        counter++;
                        DataRow row = new DataRow(ln);
                        DataRowList.Add(row);
                    }
                    file.Close();
                }
                int NumberOfRightPasswords = 0;
                foreach (DataRow row in DataRowList)
                {
                    if (row.IsRightPassword)
                    {
                        NumberOfRightPasswords++;
                    }
                }
                Console.WriteLine(NumberOfRightPasswords);
                Console.ReadKey();
            }
        }
    }
}
