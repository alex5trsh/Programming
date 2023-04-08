using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    class Discipline
    {
        private int _mark;

        public string NameOfDiscipline { get; set; }

        public string SurnameOfTeacher { get; set; }

        public int Mark
        {
            get => _mark;
            set
            {
                Validator.AssertValueInRange(value, 1, 5, "Mark");

                _mark = value;
            }
        }
        public Discipline(string nameOfDiscipline, string surnameOfTeacher,int mark)
        {
            NameOfDiscipline=nameOfDiscipline;
            SurnameOfTeacher=surnameOfTeacher;
            Mark=mark;
        }

        public Discipline()
        {
           
        }
    }
}
