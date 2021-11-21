using System;
using System.IO;

namespace HomeWork_4
{
    public class Accounts
    {
        private Account[] accounts;

        public Accounts(string fileName)
        {
            accounts = new Account[0];
            using (StreamReader reader = new(fileName))
            {
                while (!reader.EndOfStream)
                {
                    string s = reader.ReadLine();
                    string[] strs = s.Split(',');
                    Array.Resize(ref accounts, accounts.Length + 1);
                    accounts[^1] = new Account(strs[0], strs[1]);
                }
            }
        }
        public bool IsValidLogin(string login)
        {
            foreach (Account item in accounts)
            {
                if (item.Login == login)
                {
                    return true;
                }
            }
            return false;
        }
        public bool IsValidLoginPassword(string login, string password)
        {
            foreach (Account item in accounts)
            {
                if (item.IsValid(login, password))
                {
                    return true;
                }
            }
            return false;
        }
        private struct Account
        {
            private string login;
            private string password;
            public Account(string login, string password)
            {
                this.login = login;
                this.password = password;
            }
            public bool IsValid(string login, string password)
            {
                return (this.login == login && this.password == password);
            }
            public string Login => login;
        }

    }
}
