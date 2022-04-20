using P128OperatorOverloadingInCustomType.Models;
using System;

namespace P128OperatorOverloadingInCustomType
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 7;
            int b = 15;

            //Console.WriteLine(a > b);
            //Console.WriteLine(a + b);
            //Console.WriteLine(a >0 && b < 0);

            Human human1 = new Human();
            human1.Age = 18;
            Student human2 = new Student();
            Console.WriteLine((human1 + human2));

            int.TryParse("3546", out int num);
        }
    }
}
