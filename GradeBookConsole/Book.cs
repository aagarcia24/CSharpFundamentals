using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBookConsole
{
    public class Book
    {
        private List<double> grades;
        public String Name { get; set; }

        public Book(string name)
        {
            grades = new List<double>();
            Name = name;
        }
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            foreach (var grade in grades)
            {
                result.High = Math.Max(grade, result.High);
                result.Low = Math.Min(grade, result.Low);
                result.Average += grade;
            }
            result.Average /= grades.Count;

            return result;
        }
    }
}
