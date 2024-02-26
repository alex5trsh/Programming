using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View.Model;

namespace View.ViewModel
{
    class MainVM:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public Contact currentContact;

        private string _name;

        /// <summary>
        /// Номер телефона.
        /// </summary>
        private string _numberPhone;

        /// <summary>
        /// Почта.
        /// </summary>
        private string _email;

        public string Name
        {
            get => _name;
            set
            {
                if (_name != value)
                {
                    _name = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(Name));
                }
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

                if (_numberPhone != value)
                {
                    _numberPhone = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(NumberPhone));
                }
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
                if (_email != value)
                {
                    _email = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(Email));
                }
            }
        }

    }

}
