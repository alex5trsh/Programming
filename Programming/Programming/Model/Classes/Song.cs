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
        private int TimeOfSongInSeconds
        {
            //get { }
            set
            {
                if (value < 0)
                { }
            }
        }
    }
}
