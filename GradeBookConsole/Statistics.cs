using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBookConsole
{
    public class Statistics
    {
        public double Average { get; set; }
        public double High { get; set; }
        public double Low { get; set; }
        public char Letter { get; set; }

        public Statistics()
        {
            Average = 0;
            High = 0;
            Low = 0;
            Letter = ' ';
        }
    }
}
