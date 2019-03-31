using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectB
{
    class Assessment
    {
        //Attributes related to assessment from database
        private int id;
        private string title;
        private DateTime dateCreated;
        private int totalWeightage;

        /// <summary>
        /// Getter And Setterss
        /// </summary>
        public int TotalWeightage { get => totalWeightage; set => totalWeightage = value; }
        public DateTime DateCreated { get => dateCreated; set => dateCreated = value; }
        public string Title { get => title; set => title = value; }
        public int Id { get => id; set => id = value; }
        public int TotalMarks { get; set; }
    }
}

