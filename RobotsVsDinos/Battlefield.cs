using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinos
{
    class Battlefield
    {
        //member variables (HAS A)
        //has fleet and herd
        public List<Dinosaur> herd;
        public List<Robot> fleet;


        //constructor (SPAWNER)
        //spawn a fleet
        public Battlefield()
        {
            herd = new List<Dinosaur>();
        //spawn a herd
            fleet = new List<Robot>();
        }

        //member methods (CAN DO)


    }
}
