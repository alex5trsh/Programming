using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Contacts.Model.Model
{
    /// <summary>
    /// Хранит методы по проверке введенных данных.
    /// </summary>
    public class ValueValidator
    {
        /// <summary>
        /// Проверяет, что длина строки не превышает заданной длины.
        /// </summary>
        /// <param name="value">Проверяемая строка.</param>
        /// <param name="maxLength">Заданнная длина.</param>
        /// <returns>true, если длина строки не превышает заданную, в ином случае, false.</returns>
        public static bool CheckStringForMaxLength(string value,int maxLength)
        {
            if (value.Length > maxLength)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Проверяет, что строка содержит заданный символ.
        /// </summary>
        /// <param name="value">Проверяемая строка.</param>
        /// <param name="sign">Заданный символ.</param>
        /// <returns>true, если строка содержит символ, в ином случае, false.</returns>
        public static bool CheckStringForSignContent(string value, string sign)
        {
            if (value.Contains(sign))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Проверяет, что строка соответствует формату номера телефона.
        /// </summary>
        /// <param name="value">Проверяемая строка.</param>
        /// <returns>true, если строка соответствует формату номера телефона, в ином случае, false.</returns>
        public static bool CheckStringForRightFormat(string value)
        {
            Regex pattern = new Regex(@"^(\+7)(\s)(\()([0-9]){3}(\))(\s)([0-9]){3}(\-)([0-9]){2}(\-)([0-9]){2}$");

            return pattern.IsMatch(value);
        }

        /// <summary>
        /// Проверяет, что строка содержит определенные символы.
        /// </summary>
        /// <param name="value">Проверяемая строка.</param>
        /// <returns>true, если строка содержит определенные символы, в ином случае, false.</returns>
        public static bool CheckStringForRightSimbols(string value)
        {
            int val;
            if (value != "+" && value != "-" && value != "(" && value != ")" && value != " "
               && !Int32.TryParse(value, out val))
            {
                return false;
            }
            else 
            {
                return true;
            }
        }
    }
}
