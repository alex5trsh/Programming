using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные об успеваемости.
    /// </summary>
    class Discipline
    {
        /// <summary>
        /// Оценка.
        /// </summary>
        private int _mark;

        /// <summary>
        /// Возвращает и задает название.
        /// </summary>
        public string NameOfDiscipline { get; set; }

        /// <summary>
        /// Возвращает и задает фамилию.
        /// </summary>
        public string SurnameOfTeacher { get; set; }

        /// <summary>
        /// Возвращает и задает оценку. Должна состоять только из чисел от 1 до 5.
        /// </summary>
        public int Mark
        {
            get => _mark;
            set
            {
                Validator.AssertValueInRange(value, 1, 5, "Mark");

                _mark = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Discipline"/>.
        /// </summary>
        /// <param name="nameOfDiscipline">Название.</param>
        /// <param name="surnameOfTeacher">Фамилия.</param>
        /// <param name="mark">Оценка. Должна состоять только из чисел от 1 до 5.</param>
        public Discipline(string nameOfDiscipline, string surnameOfTeacher,int mark)
        {
            NameOfDiscipline=nameOfDiscipline;
            SurnameOfTeacher=surnameOfTeacher;
            Mark=mark;
        }

        /// <summary>
        /// Создает пустой экземпляр класса <see cref="Discipline"/>.
        /// </summary>
        public Discipline()
        {
           
        }
    }
}
