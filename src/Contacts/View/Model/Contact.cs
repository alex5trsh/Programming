using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Model
{
    /// <summary>
    /// Хранит контактные данные человека.
    /// </summary>
    class Contact
    {
        /// <summary>
        /// Имя.
        /// </summary>
        private string _name;

        /// <summary>
        /// Номер телефона.
        /// </summary>
        private string _numberPhone;

        /// <summary>
        /// Почта.
        /// </summary>
        private string _email;

        /// <summary>
        /// Возвращает и задает имя. Должно состоять только из букв.
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                //AssertStringContainsOnlyLetters(value, "Name");

                _name = value;
            }
        }

        /// <summary>
        /// Возвращает и задает номер. Должен состоять только из 11 положительных чисел.
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
        /// Возвращает и задает почту. Должна состоять только из букв.
        /// </summary>
        public string Email
        {
            get => _email;
            set
            {
                _email = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Contact"/>.
        /// </summary>
        /// <param name="name"> Имя. Должно состоять только из букв.</param>
        /// <param name="surname">Фамилия. Должна состоять только из букв.</param>
        /// <param name="numberPhone">Номер. Должен состоять только из 11 положительных чисел.</param>
        public Contact(string name, string email, string numberPhone)
        {
            Name = name;
            Email = email;
            NumberPhone = numberPhone;
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
                    throw new ArgumentException("Переменная свойства" + nameOfFeature
                        + "содержит только символы английского языка");
                }
            }
        }

    }
}
