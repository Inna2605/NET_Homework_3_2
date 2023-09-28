//Створіть клас «Журнал». Необхідно зберігати у полях класу:
//назву журналу, рік заснування, опис журналу, контактний телефон, email.
//Реалізуйте методи класу для введення даних, виведення даних.
//Реалізуйте доступ до окремих полів через методи класу.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Homework_3_2
{
    internal class Magazine
    {
        public string Name { get; set; }
        public string Year { get; set; }
        public string Description { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public Magazine(string name, string year, string description, string phone, string email)
        {
            Name = name;
            Year = year;
            Description = description;
            Phone = phone;
            Email = email;
        }
        public void InputData(string name, string year, string description, string phone, string email)
        {
            Name = name;
            Year = year;
            Description = description;
            Phone = phone;
            Email = email;
        }
        public void OtputData()
        {
            Console.WriteLine($"Назва журнала: {Name}");
            Console.WriteLine($"Рік заснування: {Year}");
            Console.WriteLine($"Опис журналу: {Description}");
            Console.WriteLine($"Контактний телефон: {Phone}");
            Console.WriteLine($"email: {Email}");
        }
    }
}
