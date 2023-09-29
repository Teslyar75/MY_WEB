/*
 * 2) Створіть клас «Веб-сайт». Необхідно зберігати у полях класу: 
 * назву сайту, шлях до сайту, опис сайту, ip-адресу сайту. 
 * Реалізуйте методи класу для введення даних, виведення даних.
 * Реалізуйте доступ до окремих полів через методи класу. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MY_WEB
{
    using System;

    class Website
    {
        private string name;
        private string url;
        private string description;
        private string ipAddress;

        public Website(string name, string url, string description, string ipAddress)
        {
            this.name = name;
            this.url = url;
            this.description = description;
            this.ipAddress = ipAddress;
        }

        public void InputData()
        {
            Console.Write("Введите название сайта: ");
            name = Console.ReadLine();

            Console.Write("Введите путь к сайту: ");
            url = Console.ReadLine();

            Console.Write("Введите описание сайта: ");
            description = Console.ReadLine();

            Console.Write("Введите IP-адрес сайта: ");
            ipAddress = Console.ReadLine();
        }
 
        public void DisplayData()
        {
            Console.WriteLine("Название сайта: " + GetName());
            Console.WriteLine("Путь к сайту: " + GetUrl());
            Console.WriteLine("Описание сайта: " + GetDescription());
            Console.WriteLine("IP-адрес сайта: " + GetIpAddress());
        }

        public string GetName()
        {
            return name;
        }

        public string GetUrl()
        {
            return url;
        }

        public string GetDescription()
        {
            return description;
        }

        public string GetIpAddress()
        {
            return ipAddress;
        }
    }

    class Program
    {
        static void Main()
        {
            Website website = new Website("", "", "", "");
            website.InputData();
            Console.WriteLine("\nИнформация о веб-сайте:");
            website.DisplayData();

            Console.ReadLine();
        }
    }

}
