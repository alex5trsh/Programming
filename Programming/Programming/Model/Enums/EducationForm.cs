using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// TODO: namespace (+)
namespace Programming.Model.Enums
{   
    /// <summary>
    /// Предоставляет шаблоны форм обучения. 
    /// </summary>
    public enum EducationForm
    {
        // TODO: XML для элементов перечисления (+)
        /// <summary>
        /// Очная.
        /// </summary>
        FullTime,
        /// <summary>
        /// Заочная.
        /// </summary>
        PartTime,
        /// <summary>
        /// Вечерняя.
        /// </summary>
        Evening,
        /// <summary>
        /// Дистанционная.
        /// </summary>
        Remote
    }
}