using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectB
{
    class Rubricaddclass
    {
        //attributes declared according to database
        private int id;
        private string details;
        private int cloid;

        /// <summary>
        /// Getter and setter of attributes
        /// </summary>
        public int Id { get => id; set => id = value; }
        //public string Details { get => details; set => details = value; }
        public int Cloid { get => cloid; set => cloid = value; }

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
                    details= value;
                }
                else
                {
                    //throw new Exception();
                }
            }
        }
    }
}
