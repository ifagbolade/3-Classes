using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_classes
{
    class Games
    {
        private string _gamesPlayed;
        private Coaches coaches;
        private float scorepoint;


        public string GamesPlayed { get => _gamesPlayed; set => _gamesPlayed = value; }
        internal Coaches Coaches { get => coaches; set => coaches = value; }
        public float Scorepoint { get => scorepoint; set => scorepoint = value; }

        public Games()
        {
            Console.WriteLine("Games Created" );
        }

    }
}
