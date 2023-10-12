//Створіть клас «Журнал». Необхідно зберігати у полях класу:
//назву журналу, рік заснування, опис журналу, контактний телефон, email.
//Реалізуйте методи класу для введення даних, виведення даних.
//Реалізуйте доступ до окремих полів через методи класу.

//Додайте до вже створеного класу «Журнал» інформацію про кількість працівників.
//Виконайте навантаження + (для збільшення кількості працівників на вказану кількість),
// — (для зменшення кількості працівників на вказану кількість),
// == (перевірка на рівність кількості працівників),
// < і > (перевірка на меншу чи більшу кількість працівників),
// != і Equals.Використовуйте механізм властивостей полів класу.

using NET_Homework_3_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NET_Homework_3_2
{
    internal class Magazine
    {
        public string Name { get; set; }
        public string Year { get; set; }
        public string Description { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int NumberEmployees { get; set; }

        public Magazine()
        {
            Name = null;
            Year = null;
            Description = null;
            Phone = null;
            Email = null;
            NumberEmployees = 0;
        }
        public Magazine(string name, string year, string description, string phone, string email, int number)
        {
            Name = name;
            Year = year;
            Description = description;
            Phone = phone;
            Email = email;
            NumberEmployees = number;
        }
        public void InputData(string name, string year, string description, string phone, string email, int number)
        {
            Name = name;
            Year = year;
            Description = description;
            Phone = phone;
            Email = email;
            NumberEmployees = number;
        }
        public void OtputData()
        {
            Console.WriteLine($"Назва журнала: {Name}");
            Console.WriteLine($"Рік заснування: {Year}");
            Console.WriteLine($"Опис журналу: {Description}");
            Console.WriteLine($"Контактний телефон: {Phone}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Кількість працівників: {NumberEmployees}");
        }

        public void Comparison(Magazine m1, Magazine m2)
        {
            if (m1.NumberEmployees != m2.NumberEmployees)
            {
                Console.WriteLine("\nКількість працівників в журналах не рівна:");
                if (m1.NumberEmployees < m2.NumberEmployees)
                {
                    Console.WriteLine($"Кількість працівників в журналі \"{m2.Name}\"({m2.NumberEmployees}) більша ніж в журналі \"{m1.Name}\"({m1.NumberEmployees})");
                }
                else if (m1.NumberEmployees > m2.NumberEmployees)
                {
                    Console.WriteLine($"Кількість працівників в журналі \"{m1.Name}\"({m1.NumberEmployees}) більша ніж в журналі \"{m2.Name}\"({m2.NumberEmployees})");
                }
            }
            else if (m1.NumberEmployees == m2.NumberEmployees)
            {
                Console.WriteLine("\nКількість працівників в журналах рівна:");
                Console.WriteLine($"Кількість працівників в журналі \"{m1.Name}\"({m1.NumberEmployees}) рівна кількості працівників в журналі \"{m2.Name}\"({m2.NumberEmployees})");
            }
        }
        public static Magazine operator +(Magazine magazine, int n)
        {
            magazine.NumberEmployees += n;
            return magazine;
        }
        public static Magazine operator -(Magazine magazine, int n)
        {
            magazine.NumberEmployees -= n;
            return magazine;
        }
        public static bool operator ==(Magazine magazine1, Magazine magazine2)
        {
            return magazine1.NumberEmployees == magazine2.NumberEmployees;
        }
        public static bool operator !=(Magazine magazine1, Magazine magazine2)
        {
            return magazine1.NumberEmployees != magazine2.NumberEmployees;
        }
        public static bool operator <(Magazine magazine1, Magazine magazine2)
        {
            return magazine1.NumberEmployees < magazine2.NumberEmployees;
        }
        public static bool operator >(Magazine magazine1, Magazine magazine2)
        {
            return magazine1.NumberEmployees > magazine2.NumberEmployees;

        }
        public static bool Equals(Magazine magazine1, Magazine magazine2)
        {
            return magazine1 != magazine2;
        }


        /*public override bool Equals (object obj)
        {
            if (obj is Magazine m)
            {
                return this.Name != m.Name &&
                       this.Year != m.Year &&
                       this.Description != m.Description &&
                       this.Phone != m.Phone &&
                       this.Email != m.Email &&
                       this.NumberEmployees != m.NumberEmployees;
            }
            return true;
        }*/

       /* public override int GetHashCode()
        {
            return HashCode.Combine(Name, Year, Description, Phone, Email, NumberEmployees);
        }*/
    }
}
