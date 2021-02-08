using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_classes
{
    class Startup
    {
        public List<Coaches> CoachesList;
        public List<Games> GamesList;
        public List<Location> LocationList;
        
        public Startup()
        {
            Console.WriteLine("Location started.");
            LocationList = new List<Location>();

        }
    }
}
