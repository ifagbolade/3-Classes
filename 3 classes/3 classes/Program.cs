using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            Create a project that will deals with sports (football)
            Classes could include coaches and shows the name 
            Games played, like the schdule opponets
            Locations could be the statidum name, cities 
            May be weathers 
             */
            Coaches MikeTomlin = new Coaches();
            MikeTomlin.Name = "MikeTomlin";
            Games g1 = new Games();
            g1.Coaches = MikeTomlin;
            g1.Scorepoint = 60;  
            g1.GamesPlayed = "Aginst Browns ";

            Games g2 = new Games();
            g2.Coaches = MikeTomlin;
            g2.Scorepoint = 20;
            g2.GamesPlayed = "Aganist Ravens";

            Games g3 = new Games();
            g3.Coaches = MikeTomlin;
            g3.Scorepoint = 35;
            g3.GamesPlayed = "Aganist Colt";

            Location pc = new Location();
            pc.DesignDate = new DateTime(2001, 8, 18);
            pc.LocationName = " Heinz Field";
            pc.thiscoaches = MikeTomlin;
            pc.thistadiumLook = StadiumLook.flatfield;
            pc.thisLocationArea = LocationArea.snow;
            // ... 

            // new coaches 
            Coaches AndyReid = new Coaches();
            AndyReid.Name = "AndyReid";
            Games gp1 = new Games();
            gp1.Coaches = AndyReid;
            gp1.Scorepoint = 40;
            gp1.GamesPlayed = "Aginst Charger ";

            Games gp2 = new Games();
            gp2.Coaches = AndyReid;
            gp2.Scorepoint = 50;
            gp2.GamesPlayed = "Aganist Rams";

            Games gp3 = new Games();
            gp3.Coaches = AndyReid;
            gp3.Scorepoint = 35;
            gp3.GamesPlayed = "Aganist Packers";

            Location pcs = new Location();
            pcs.DesignDate = new DateTime(1972, 8, 12);
            pcs.LocationName = " Arrowhead Stadium";
            pcs.thiscoaches = AndyReid;
            pcs.thistadiumLook = StadiumLook.Bowl;
            pcs.thisLocationArea = LocationArea.cloudy;
            // ... 

          Startup myStartup = new Startup();
            myStartup.LocationList.Add(pc);
            myStartup.LocationList.Add(pcs);
            Console.ReadLine();



        }
    }
}
