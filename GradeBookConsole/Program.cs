using System;
using System.Collections.Generic;

namespace GradeBookConsole
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var book = new Book("");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);
            book.ShowStatistics();
        }
    }
}
