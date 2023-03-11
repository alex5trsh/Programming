using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    class Contact
    {
        private string Name { get; set; }

        private string Surname { get; set; }

        private string _numberPhone;

        private string NumberPhone
        {
            get => _numberPhone;
            set
            {
                if (value.Length>11)
                {
                    throw new ArgumentException();
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
    }
}
