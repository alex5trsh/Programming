using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace View.Model
{
    /// <summary>
    /// Хранит контактные данные человека.
    /// </summary>
    public class Contact : INotifyPropertyChanged, ICloneable
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
                    OnPropertyChanged(nameof(Name));
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
                    OnPropertyChanged(nameof(NumberPhone));
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
                    OnPropertyChanged(nameof(Email));
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

        /// <summary>
        /// Событие на изменение какого-либо свойства класса <see cref="Contact"/>.
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        /// <inheritdoc />
        public object Clone()
        {
            return new Contact(this.Name, this.NumberPhone, this.Email);
        }
    }
}
