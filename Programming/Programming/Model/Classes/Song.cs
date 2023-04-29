using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о песнях.
    /// </summary>
    class Song
    {
        /// <summary>
        /// Продолжительность.
        /// </summary>
        private int _timeOfSong;

        /// <summary>
        /// Возвращает и задает название песни.
        /// </summary>
        public string NameOfSong { get; set; }

        /// <summary>
        /// Возвращает и задает имя исполнителя.
        /// </summary>
        public string NameOfSinger{ get; set; }

        /// <summary>
        /// Возвращает и задает продолжительность. Должна состоять только из положительных чисел.
        /// </summary>
        public int TimeOfSong
        {
            get => _timeOfSong;
            set
            {
                Validator.AssertOnPositiveValue(value, "TimeOfSong");

                _timeOfSong = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Song"/>.
        /// </summary>
        /// <param name="nameOfSong">Название песни.</param>
        /// <param name="nameOfSinger">Имя исполнителя.</param>
        /// <param name="timeOfSong">Продолжительность. Должна состоять только из положительных чисел.</param>
        public Song(string nameOfSong, string nameOfSinger, int timeOfSong)
        {
            NameOfSong = nameOfSong;
            NameOfSinger = nameOfSinger;
            TimeOfSong = timeOfSong;
        }

        /// <summary>
        /// Создает пустой экземпляр класса <see cref="Song"/>.
        /// </summary>
        public Song()
        {
            
        }
    }
}
