﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectB
{
    class studentattendence
    {
        //atrributes according to database 
        private int attendenceId;
        private int studentId;
        private int attendenceStatus;

        /// <summary>
        /// getter and setters
        /// </summary>
        public int AttendenceStatus { get => attendenceStatus; set => attendenceStatus = value; }
        public int StudentId { get => studentId; set => studentId = value; }
        public int AttendenceId { get => attendenceId; set => attendenceId = value; }
    }
}
