using System;
using System.Collections.Generic;

namespace CsharpCourse
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            person person = new person();
            person.firstName = "Vitaly";
            person.lastName = "Kovalev";
            person.age = 35;

            person person2 = new person();
            person2.firstName = "Natalya";
            person2.lastName = "Kovaleva";
            person2.age = 42;
            person2.sex = "female";

            person person3 = new person();
            person3.firstName = "Olga";
            person3.lastName = "Koaleva";
            person3.age = 5;
            
        }

    }

    internal class Person
    {
        public string firstName;
        public string lastName;
        public int age;
    }
}