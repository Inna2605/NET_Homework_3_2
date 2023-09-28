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
        private string _name;
        private string _year;
        private string _description;
        private string _phone;
        private string _email;
        public Magazine(string name, string year, string description, string phone, string email)
        {
            _name = name;
            _year = year;
            _description = description;
            _phone = phone;
            _email = email;
        }
        public void InputData(string name, string year, string description, string phone, string email)
        {
            _name = name;
            _year = year;
            _description = description;
            _phone = phone;
            _email = email;
        }
        public void OtputData()
        {
            Console.WriteLine($"Назва журнала: {_name}");
            Console.WriteLine($"Рік заснування: {_year}");
            Console.WriteLine($"Опис журналу: {_description}");
            Console.WriteLine($"Контактний телефон: {_phone}");
            Console.WriteLine($"email: {_email}");
        }
        public string Name
        { get { return _name; } 
          set { _name = value; }
        }
        public string Year
        {
            get { return _year; }
            set { _year = value; }
        }
        public string Description
        { 
            get { return _description; } 
            set {  _description = value; } 
        }
        public string Phone
        { 
            get { return _phone; } 
            set {  _phone = value; } 
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
    }
}
