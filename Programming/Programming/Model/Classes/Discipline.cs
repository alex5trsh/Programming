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

        private int _mark;

        private int Mark
        {
            get => _mark;
            set
            {
                if (value < 0||value>6)
                {
                    throw new ArgumentException();
                }
                _mark = value;
            }
        }
        public Discipline(string nameOfDiscipline, string surnameOfTeacher,int mark)
        {
            NameOfDiscipline=nameOfDiscipline;
            SurnameOfTeacher=surnameOfTeacher;
            Mark=mark;
        }
    }
}
