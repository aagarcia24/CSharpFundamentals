using System;

namespace GradeBookConsole
{
    public abstract class Book : NamedObject, IBook
    {
        public Book(string name) : base(name)
        {

        }

        public virtual event GradeAddedDelegate GradeAdded;

        public abstract void AddGrade(double grade);

        public abstract Statistics GetStatistics();
    }
}
