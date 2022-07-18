using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flex_exercise
{
    public class DataRow
    {
        public int MinCount { get; set; }
        public int MaxCount { get; set; }
        public char CharacterToContain { get; set; }
        public string Password { get; set; }
        public bool IsRightPassword
        {
            get
            {
                int count = Password.Count(f => f == CharacterToContain);
                return MinCount <= count && count <= MaxCount;
            }
        }
        public DataRow(string inputRow)
        {
            // datarow example: 8-9 b: pbbbbbbkbz
            string[] inputRowDivided = inputRow.Split(' ');
            MinCount = int.Parse(inputRowDivided[0].Split('-')[0]);
            MaxCount = int.Parse(inputRowDivided[0].Split('-')[1]);
            CharacterToContain = inputRowDivided[1][0];
            Password = inputRowDivided[2];
        }
        public DataRow(int minCount, int maxCount, char characterToContain, string password)
        {
            MinCount = minCount;
            MaxCount = maxCount;
            CharacterToContain = characterToContain;
            Password = password;
        }
    }
}
