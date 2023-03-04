using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    class Discipline
    {
        private string NameOfDiscipline { get; set; }
        private string SurnameOfTeacher { get; set; }
        private int Mark
        {
            //get { }
            set
            {
                if (value < 0||value>6)
                { }
            }
        }
    }
}
