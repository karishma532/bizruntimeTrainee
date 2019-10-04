using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Referance1
{

    class Person

    {

        public int age;

    }

    class Program

    {

        static void Square(Person a, Person b)

        {

            a.age = a.age * a.age;

            b.age = b.age * b.age;

            Console.WriteLine(a.age + " " + b.age);

        }

        static void Main(string[] args)

        {

            Person p1 = new Person();

            Person p2 = new Person();

            Person p3 = new Person();

            Person p4 = new Person();

            p1.age = 5;

            p2.age = 10;

            p3.age = 15;

            p4.age = 20;

            Console.WriteLine(p1.age + " " + p2.age);

            Square(p1, p2);

            Console.WriteLine(p3.age + " " + p4.age);

             Console.ReadKey();

        }

    }

}
    