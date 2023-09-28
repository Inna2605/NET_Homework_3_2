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
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Magazine magazine = new Magazine("Мій журнал", "2020", "Опис мого журнала", "2233445566", "my_address@gmail.com");
            Console.WriteLine("Дані мого журнала:");
            magazine.OtputData();

            Console.WriteLine();    
            magazine.InputData("Новий журнал", "2023", "Опис нового журнала", "9988776655", "new_address@gmail.com");
            Console.WriteLine("Нові дані журнала:");
            magazine.OtputData();
            Console.ReadLine();
        }
    }
}
