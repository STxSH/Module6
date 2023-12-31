﻿using System.Drawing;

namespace Module6
{
    internal class Program
    {
        //task 6.6.2
        static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }

    class User
    {
        private int age;
        private string login;
        private string email;

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                if (value < 18)
                {
                    Console.WriteLine("Возраст должен быть не меньше 18");
                }
                else
                {
                    age = value;
                }
            }
        }

        public string Login
        {
            get
            {
                return login;
            }

            set
            {
                if (value.Length >= 3)
                {                   
                    login = value;
                }
                else
                {
                    Console.WriteLine("Поле логина должно быть не менее 3 символов длиной.");
                }
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                if (value.Contains('@'))
                {
                    email = value;
                }
                else
                {
                    Console.WriteLine("Поле почты должно содержать знак @.");
                }
            }
        }
    }
}