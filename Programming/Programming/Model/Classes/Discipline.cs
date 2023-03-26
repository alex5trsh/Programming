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
	            if (value < 0 || value > 6)
	            {
		            throw new ArgumentException("Оценка находится в диапазоне от 1 до 5 ");
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

        public Discipline()
        {
           
        }
    }
}
