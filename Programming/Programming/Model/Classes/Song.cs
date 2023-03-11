using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    class Song
    {
        private string NameOfSong { get; set; }

        private string NameOfSinger{ get; set; }

        private int _timeOfSong;
        private int TimeOfSong
        {
            get => _timeOfSong;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                _timeOfSong = value;
            }
        }
        public Song(string nameOfSong, string nameOfSinger, int timeOfSong)
        {
            NameOfSong = nameOfSong;
            NameOfSinger = nameOfSinger;
            TimeOfSong = timeOfSong;
        }
    }
}
