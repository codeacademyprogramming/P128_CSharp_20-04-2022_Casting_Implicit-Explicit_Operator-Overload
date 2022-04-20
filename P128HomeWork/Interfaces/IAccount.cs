using System;
using System.Collections.Generic;
using System.Text;

namespace P128HomeWork.Interfaces
{
    interface IAccount
    {
        bool PasswordChecker(string password);
        void ShowInfo();
    }
}
