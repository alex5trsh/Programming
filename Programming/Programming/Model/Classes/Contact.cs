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

        public string Name { get; set; }

        public string Surname { get; set; }

        public string NumberPhone
        {
            get => _numberPhone;
            set
            {
                if (value.Length>11)
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
    }
}
