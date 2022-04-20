using System;
using System.Collections.Generic;
using System.Text;

namespace P128OperatorOverloadingInCustomType.Models
{
    class Human
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public static int operator +(Human first, Student second)
        {
            return first.Age + second.Age;
        }

        public static double operator /(Human first, Human second)
        {
            return (double)first.Age / (double)second.Age;
        }

        public static int operator *(Human first, Human second)
        {
            return first.Age * second.Age;
        }

        public static bool operator >(Human first, Human second)
        {
            return first.Age > second.Age;
        }

        public static bool operator <(Human first, Human second)
        {
            return first.Age < second.Age;
        }

        public static bool operator ==(Human first, Human second)
        {
            return first.Age > second.Age;
        }

        public static bool operator !=(Human first, Human second)
        {
            return first.Age > second.Age;
        }

        public static bool operator >=(Human first, Human second)
        {
            return first.Age >= second.Age;
        }

        public static bool operator <=(Human first, Human second)
        {
            return first.Age <= second.Age;
        }
    }
}
