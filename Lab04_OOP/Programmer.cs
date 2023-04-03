using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_OOP
{
    class Programmer : IDeveloper, IComparable<IDeveloper>
    {
        private string _level;
        public string Tool
        {
            get { return _level; }
            set { _level = value; }
        }

        public Programmer(string level)
        {
           _level = level;
        }

        public void Create(int i)
        {
            Console.Write($"Write the {i + 1} developer level : ");
            _level = Console.ReadLine();
        }

        public void Destroy(int j)
        {
            Console.WriteLine($"We destroy {j + 1} developer level; ");
        }


        int IComparable<IDeveloper>.CompareTo(IDeveloper other)
        {
            return String.Compare(this.Tool, other.Tool);
        }

        public override string ToString()
        {
            return $"My programmer level is {Tool}";
        }
    }
}
