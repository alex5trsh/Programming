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
        private string NumberPhone
        {
            //get { }
            set
            {
                if (value.Length>9)
                { }
            }
        }
    }
}
