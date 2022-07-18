using System;
using System.Collections.Generic;
using System.IO;

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
                    string ln;
                    int NumberOfRightPasswords = 0;

                    while ((ln = file.ReadLine()) != null)
                    {
                        DataRow row = new DataRow(ln);
                        DataRowList.Add(row);
                        if (row.IsRightPassword)
                        {
                            NumberOfRightPasswords++;
                        }
                    }
                    file.Close();
                    Console.WriteLine("Number of valid passwords: {0}",NumberOfRightPasswords);
                }
                Console.ReadKey();
            }
        }
    }
}
