using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    class Contact
    {
        private string _numberPhone;

        private string _name;

        private string _surname;

        public string Name
        {
            get => _name;
            set
            {
                AssertStringContainsOnlyLetters(value, "Name");

                _name = value;
            }
        }

        public string Surname
        {
            get => _surname;
            set
            {
                AssertStringContainsOnlyLetters(value, "SurName");

                _surname = value;

            }
        }

        public string NumberPhone
        {
            get => _numberPhone;
            set
            {
                if (value.Length != 11)
                {
                    throw new ArgumentException("Номер не больше 11 знаков");
                }

                _numberPhone = value;
            }
        }

        public Contact(string name, string surname, string numberPhone)
        {
            Name =name;
            Surname =surname;
            NumberPhone =numberPhone;
        }

        public Contact()
        {
            
        }

        private void AssertStringContainsOnlyLetters(string value, string nameOfFeature)
        {
            for (int i = 0; i < value.Length; i++)
            {
                if (((value[i] >= 'a' && value[i] <= 'z') || (value[i] >= 'A' && value[i] <= 'Z')) == false)
                {
                    throw new ArgumentException("Переменная свойства" + nameOfFeature + "содержит только символы английского языка");
                }
            }

        }
    }
}
