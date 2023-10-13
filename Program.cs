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
            Magazine magazine1 = new Magazine("Мій журнал", "2020", "Опис мого журнала", "2233445566", "my_address@gmail.com", 10);
            Console.WriteLine("Дані мого журнала:");
            magazine1.OtputData();
                      
            Console.WriteLine(); 
            Magazine magazine2 = new Magazine();
            magazine2.InputData("Новий журнал", "2023", "Опис нового журнала", "9988776655", "new_address@gmail.com", 12);
            Console.WriteLine("Нові дані журнала:");
            magazine2.OtputData();

            magazine1.Comparison(magazine1, magazine2);

            magazine1.NumberEmployees = magazine1.NumberEmployees + 5;
            Console.WriteLine($"\nКількість працівників в журналі \"{magazine1.Name}\" збільшено на 5 чоловік : {magazine1.NumberEmployees}");

            magazine1.Comparison(magazine1, magazine2);

            magazine2.NumberEmployees = magazine2.NumberEmployees - 8;
            Console.WriteLine($"\nКількість працівників в журналі \"{magazine2.Name}\" зменшено на 8 чоловік : {magazine2.NumberEmployees}");

            magazine1.Comparison(magazine1, magazine2);

            magazine2.NumberEmployees = magazine2.NumberEmployees + 11;
            Console.WriteLine($"\nКількість працівників в журналі \"{magazine2.Name}\" збільшено на 11 чоловік : {magazine2.NumberEmployees}");

            magazine1.Comparison(magazine1, magazine2);

            magazine2.Equals(magazine1);

            magazine1 = magazine2;
            Magazine magazine = new Magazine();
            Console.WriteLine($"\nПорівняння журналів Equals (magazine1, magazine2): {Equals(magazine1, magazine2)}");
            Console.WriteLine($"Порівняння журналів Equals (magazine1, magazine): {Equals(magazine1, magazine)}");

            Console.ReadLine();
        }
    }
}
