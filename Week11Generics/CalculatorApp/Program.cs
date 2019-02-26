using System;
using System.Collections.Generic;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new CalculatorV2();

            //var param1 = new Value(1);
            //var param2 = new Value(2);

            //var x = c.Add(param1, param2);

            var s1 = new Student("And");
            var s2 = new Student("rei");
            
            var s3 = c.Add(s1, s2);

            var list = new List<Student>();
        }
    }

    public class Value : IHaveAnAddMethod<Value>
    {
        public int Val { get; set; }

        public Value(int a)
        {
            Val = a;
        }

        public Value Add(Value p)
        {
            var i = this.Val + p.Val;

            return new Value(i);
        }
    }

    public class Student : IHaveAnAddMethod<Student>
    {
        public Student(string a)
        {
            this.Name = a;
        }

        public string Name { get; set; }

        public Student Add(Student p)
        {
            var res = this.Name + p.Name;

            return new Student(res);
        }
    }
}
