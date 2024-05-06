using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Contacts.Model.Model
{
    /// <summary>
    /// Хранит контактные данные человека.
    /// </summary>
    public class Contact
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
        /// Возвращает и задает имя. 
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                if (_name != value)
                {
                    _name = value;
                }
            }
        }

        /// <summary>
        /// Возвращает и задает номер.
        /// </summary>
        public string NumberPhone
        {
            get => _numberPhone;
            set
            {
                if (_numberPhone != value)
                {
                    _numberPhone = value;
                }
            }
        }

        /// <summary>
        /// Возвращает и задает почту. 
        /// </summary>
        public string Email
        {
            get => _email;
            set
            {
                if (_email != value)
                {
                    _email = value;
                }
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Contact"/>.
        /// </summary>
        /// <param name="name"> Имя.</param>
        /// <param name="surname">Фамилия.</param>
        /// <param name="numberPhone">Номер.</param>
        public Contact(string name, string numberPhone, string email)
        {
            Name = name;
            NumberPhone = numberPhone;
            Email = email;
        }

        /// <summary>
        /// Создает пустой экземпляр класса <see cref="Contact"/>.
        /// </summary>
        public Contact()
        {

        }
    }
}
