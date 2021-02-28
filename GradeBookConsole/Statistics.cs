using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBookConsole
{
    public class Statistics
    {
        public double High { get; set; }
        public double Low { get; set; }
        public double Sum { get; set; }
        public int Count { get; set; }

        public double Average
        {
            get
            {
                return Sum / Count;
            }
        }
        public char Letter
        {
            get
            {
                switch (Average)
                {
                    case var d when d >= 90:
                        return 'A';
                    case var d when d >= 80:
                        return 'B';
                    case var d when d >= 70:
                        return 'C';
                    case var d when d >= 60:
                        return 'D';
                    default:
                        return 'F';
                }
            }
        }
        public Statistics()
        {
            High = double.MinValue;
            Low = double.MaxValue;
            Sum = 0.0;
            Count = 0;
        }

        public void Add(double number)
        {
            Sum += number;
            Count++;
            High = Math.Max(number, High);
            Low = Math.Min(number, Low);
        }
    }
}
