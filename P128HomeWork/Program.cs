using P128HomeWork.Models;
using System;

namespace P128HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Email Daxil Et:");
            string email = Console.ReadLine();
            Console.WriteLine("\nSifreni Daxil Et:");
            string password = Console.ReadLine();

            User user = new User(email, password);
            user.FullName = "Hamid Mammadov";

            user.ShowInfo();
        }
    }
}
