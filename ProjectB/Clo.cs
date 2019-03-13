using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectB
{
    class Clo
    {
        private int id;
        private string name;
        private DateTime datecreated;
        private DateTime dateupdated;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public DateTime Datecreated { get => datecreated; set => datecreated = value; }
        public DateTime Dateupdated { get => dateupdated; set => dateupdated = value; }
    }
}
