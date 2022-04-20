using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;
using P128HomeWork.Interfaces;

namespace P128HomeWork.Models
{
    class User : IAccount
    {
        public string FullName;
        public string Email;
        private string _password;
        public string Password 
        {
            get => _password;
            set
            {
                while (!PasswordChecker(value))
                {
                    Console.WriteLine("Duzgun Daxil Et");
                    value = Console.ReadLine();
                }
                _password = value;
            }
        }

        public User(string email, string password)
        {
            Email = email;
            Password = password;
        }


        public bool PasswordChecker(string password)
        {
            if (password.Length >= 8)
            {
                bool checkDigit = false;
                bool checkLower = false;
                bool checkUpper = false;

                foreach (char item in password)
                {
                    if (char.IsUpper(item))
                    {
                        checkUpper = true;
                    }
                    else if (char.IsLower(item))
                    {
                        checkLower = true;
                    }
                    else if (char.IsDigit(item))
                    {
                        checkDigit = true;
                    }

                    if (checkDigit && checkLower && checkUpper)
                    {
                        return true;
                    }
                }

                if (!checkDigit || !checkLower || !checkUpper)
                {
                    return false;
                }
            }
            return false;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Ad Soyad: {FullName} Email: {Email}");
        }
    }
}
