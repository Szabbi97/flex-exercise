using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flex_exercise
{
    public class DataRow
    {
        /// <summary>
        /// Minimum amount of the specified character
        /// </summary>
        private int MinCount { get; set; }
        /// <summary>
        /// Maximum amount of the specified character
        /// </summary>
        private int MaxCount { get; set; }
        /// <summary>
        /// The character that must be in the password
        /// </summary>
        private char CharacterToContain { get; set; }
        /// <summary>
        /// Password string
        /// </summary>
        private string Password { get; set; }
        /// <summary>
        /// Is the character count between minimum and maximum amount?
        /// </summary>
        public bool IsRightPassword
        {
            get
            {
                int count = Password.Count(f => f == CharacterToContain);
                return MinCount <= count && count <= MaxCount;
            }
        }
        /// <summary>
        /// Constructor for the input row
        /// </summary>
        /// <param name="inputRow">One row from the input text</param>
        public DataRow(string inputRow)
        {
            // datarow example: 8-9 b: pbbbbbbkbz
            string[] inputRowDivided = inputRow.Split(' ');
            MinCount = int.Parse(inputRowDivided[0].Split('-')[0]);
            MaxCount = int.Parse(inputRowDivided[0].Split('-')[1]);
            CharacterToContain = inputRowDivided[1][0];
            Password = inputRowDivided[2];
        }
        /// <summary>
        /// Constructor for separate values
        /// </summary>
        /// <param name="minCount">Minimum amount of the specified character</param>
        /// <param name="maxCount">Maximum amount of the specified character</param>
        /// <param name="characterToContain">The character that must be in the password</param>
        /// <param name="password">Password string</param>
        public DataRow(int minCount, int maxCount, char characterToContain, string password)
        {
            MinCount = minCount;
            MaxCount = maxCount;
            CharacterToContain = characterToContain;
            Password = password;
        }
    }
}
