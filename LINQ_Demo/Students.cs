using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ_Demo
{
    public class Students:IComparable<Students>
    {
        public string name { get; set; }
        public int age { get; set; }
        public int grade { get; set; }

        public Students(String name, int age, int grade)
        {
            this.name = name;
            this.age = age;
            this.grade = grade;
        }

        public int CompareTo(Students student)
        {
            if(this.name == student.name)
            {
                return this.age.CompareTo(student.age);
            }

            return student.name.CompareTo(this.name);
        }

        public string toString()
        {
            return this.name + ", " + this.age;
        }
    }
}
