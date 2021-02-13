using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_classes
{
    class Coaches
    {
        private string _name;
        public string Name { get => _name; set => _name = value; }
        /*
        public List<Coaches> CoachesList;
        public List<Games> GamesList;
        public List<Location> LocationList; */ 

        public Coaches()
        {
            Console.WriteLine("Coaches Created" );

           // Console.WriteLine("Location started.");
           // LocationList = new List<Location>();
        }

    }
    
}
