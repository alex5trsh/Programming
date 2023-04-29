using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о полетах.
    /// </summary>
    class Flight
    {        
        /// <summary>
        /// Время.
        /// </summary>
        private int _timeOfFlight;

        /// <summary>
        /// Пункт вылета.
        /// </summary>
        public string DeparturePoint { get; set; }

        /// <summary>
        /// Пункт прибытия.
        /// </summary>
        public string DestinationPoint { get; set; }

        /// <summary>
        /// Возвращает и задает время. Должно состоять только из положительных чисел.
        /// </summary>
        public int TimeOfFlight
        {
            get => _timeOfFlight;
            set
            {
                Validator.AssertOnPositiveValue(value, "TimeOfFlight");

                _timeOfFlight = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Flight"/>.
        /// </summary>
        /// <param name="departurePoint">Пункт вылета.</param>
        /// <param name="destinationPoint">Пункт прибытия.</param>
        /// <param name="timeOfFlight">Время полета. Должно состоять только из положительных чисел.</param>
        public Flight(string departurePoint, string destinationPoint, int timeOfFlight)
        {
            DeparturePoint= departurePoint;
            DestinationPoint= destinationPoint;
            TimeOfFlight= timeOfFlight;
        }

        /// <summary>
        /// Создает пустой экземпляр класса <see cref="Flight"/>.
        /// </summary>
        public Flight()
        {
            
        }
    }
}
