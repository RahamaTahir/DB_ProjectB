using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectB
{
    class levelrubrics
    {
        //Attribute declared according to database
        private int id;
        private int rubricId;
        private string details;
        private int measurementLevel;

        /// <summary>
        /// Getter and setters
        /// </summary>
        public int Id { get => id; set => id = value; }
        public int RubricId { get => rubricId; set => rubricId = value; }
        //public string Details { get => details; set => details = value; }
        public int MeasurementLevel { get => measurementLevel; set => measurementLevel = value; }

        public string Details
        {
            get
            { return details; }

            set
            {
                bool flag = true;
                if (string.IsNullOrEmpty(value))
                { flag = false; }
                else
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        if (!Char.IsLetter(value[i]) && !Char.IsWhiteSpace(value[i]))
                        {
                            flag = false;
                        }
                    }
                }
                if (flag == true)
                {
                    details = value;
                }
                else
                {
                    throw new Exception();
                }
            }
        }
    }
}
