using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectB
{
    class levelrubrics
    {
        private int id;
        private int rubricId;
        private string details;
        private int measurementLevel;

        public int Id { get => id; set => id = value; }
        public int RubricId { get => rubricId; set => rubricId = value; }
        public string Details { get => details; set => details = value; }
        public int MeasurementLevel { get => measurementLevel; set => measurementLevel = value; }
    }
}
