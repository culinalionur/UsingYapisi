using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverLoading
{
    public class Student
    {
        public Student(string name,string lastname,int age, int number,int speed)
        {
            Name = name;
            LastName= lastname;
            Age = age;
            Number = number;
            Speed = speed;
        }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Number { get; set; }
        public int Speed { get; set; }

        public static bool operator ==(Student s1,Student s2)
        {
            return s1.LastName == s2.LastName;
        }
        public static bool operator !=(Student s1, Student s2)
        {
            return s1.LastName != s2.LastName;
        }
        public static int operator +(Student s1,Student s2)
        {
            var result1 = s1.Age / s1.Speed;
            var result2 = s2.Age / s2.Speed;
            var finalResult = result1 + result2;
            return finalResult;
        }
      public static Student Sum(Student s1,Student s2)
        {
            var sum = s1.Age + s2.Age;
            s1.Age = sum;
            return s1;
        }

    }
}
