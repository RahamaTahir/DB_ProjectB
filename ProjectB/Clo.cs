using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectB
{
    class Clo
    {
        //attributes related to form are created
        private int id;
        private string name;
        private DateTime datecreated;
        private DateTime dateupdated;


        //getter and setters
        public int Id { get => id; set => id = value; }
        //public string Name { get => name; set => name = value; }
        public DateTime Datecreated { get => datecreated; set => datecreated = value; }
        public DateTime Dateupdated { get => dateupdated; set => dateupdated = value; }

        public string Name
        {
            get
            { return name; }

            set
            {
                bool flag = true;
                if (string.IsNullOrEmpty(value))
                { flag = false; }
                if (flag == true)
                {
                    name = value;
                }
                else
                {
                    throw new Exception();
                }
            }
        }
    }
}
