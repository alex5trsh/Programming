using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит контактные данные человека.
    /// </summary>
    class Contact
    {
       /// <summary>
       /// Номер телефона человека.
       /// </summary>
        private string _numberPhone;

        /// <summary>
        /// Имя человека.
        /// </summary>
        private string _name;

        /// <summary>
        /// Фамилия человека.
        /// </summary>
        private string _surname;

        /// <summary>
        /// Возвращает и задает имя человека. Должно состоять только из букв.
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                AssertStringContainsOnlyLetters(value, "Name");

                _name = value;
            }
        }

        /// <summary>
        /// Возвращает и задает фамилию человека. Должна состоять только из букв.
        /// </summary>
        public string Surname
        {
            get => _surname;
            set
            {
                AssertStringContainsOnlyLetters(value, "SurName");

                _surname = value;

            }
        }

        /// <summary>
        /// Возвращает и задает номер человека. Должен состоять только из чисел в количестве 11 штук.
        /// </summary>
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

        /// <summary>
        /// Создает экземляр класса <see cref="Contact"/>.
        /// </summary>
        /// <param name="name"> Имя. Должно состоять только из букв.</param>
        /// <param name="surname">Фамилия. Должна состоять только из букв.</param>
        /// <param name="numberPhone">Номер. Должен состоять только из цифр в количестве 11 штук.</param>
        public Contact(string name, string surname, string numberPhone)
        {
            Name =name;
            Surname =surname;
            NumberPhone =numberPhone;
        }

        /// <summary>
        /// Создает пустой экземпляр класса <see cref="Contact"/>.
        /// </summary>
        public Contact()
        {
            
        }

        /// <summary>
        /// Проверяет, что строка состоит только из букв английского алфавита.
        /// </summary>
        /// <param name="value">Проверяемая строка.</param>
        /// <param name="nameOfFeature">Имя свойства, которое подлежит проверке.</param>
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
