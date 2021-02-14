using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_classes
{
    
        enum LocationArea
        {
         sunny,
         cloudy,
         snow,
         rain
  
        }
        enum StadiumLook
        {
         circle,
         Bowl,
         flatfield,
         superdome

        }
    class Location
    {
        public string LocationName;
        public LocationArea thisLocationArea;
        public StadiumLook thistadiumLook;
        public Coaches thiscoaches;
        public DateTime DesignDate; 
        public List<Coaches> CoachesGethired;
        public Location ()
        {
            Console.WriteLine("Location created");
            CoachesGethired = new List <Coaches>();
        }
    }
}
