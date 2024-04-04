using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class User : IComparable
    {
        public string Name { get; set; }
        public double Grade { get; set; }

        public User(string name, double grade)
        {
            Name = name;
            Grade = grade;
        }

        public override string ToString()
        {
            return $"{Name} - {Grade}";
        }

        public int CompareTo(object? obj)
        {
            return (int)(((obj as User).Grade - Grade)*10);
        }
    }
}
