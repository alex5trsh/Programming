using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    class Song
    {
        private int _timeOfSong;

        public string NameOfSong { get; set; }

        public string NameOfSinger{ get; set; }

        public int TimeOfSong
        {
            get => _timeOfSong;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Время не может быть отрицательным");
				}
				// TODO: RSDN
				_timeOfSong = value;
            }
        }
        public Song(string nameOfSong, string nameOfSinger, int timeOfSong)
        {
            NameOfSong = nameOfSong;
            NameOfSinger = nameOfSinger;
            TimeOfSong = timeOfSong;
        }

        public Song()
        {
            
        }
    }
}
