using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_OOP
{
    internal class Builder : IDeveloper, IComparable<IDeveloper>
    {

        private string _tool;
        public string Tool
        {
            get { return _tool; }
            set { _tool = value; }
        }

        public Builder(string tool)
        {
            Tool = tool;
        }

        public void Create(int i)
        {
            Console.Write($"Write the {i + 1} builder tool : ");
            _tool = Console.ReadLine();
        }

        public void Destroy(int j)
        {
            Console.WriteLine($"We destroy {j+1} builder tool; ");
        }

        public int CompareTo(IDeveloper? other)
        {
            return String.Compare(this.Tool, other.Tool);
        }

        public override string ToString()
        {
            return $"My builder tool is {Tool}";
        }

    }
}
