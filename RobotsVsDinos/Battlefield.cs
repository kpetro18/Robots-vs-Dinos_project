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
           //fleet = new List<Robot>();
        }

        //member methods (CAN DO)
        public Dinosaur CreateDino(string dinosaurType, int dinosaurHealth, int dinosaurEnergyLevel, int dinosaurAttack)
        {
            Dinosaur dino = new Dinosaur(dinosaurType, dinosaurHealth, dinosaurEnergyLevel, dinosaurAttack);
            PopulateHerd(dino);
            return dino;
        }
        public void PopulateHerd(Dinosaur dino)
        {
            herd.Add(dino);
        }

        public Robot CreateRobot(int robotHealth, int robotPowerLevel, string robotWeaponType)
        {
            Robot robo = new Robot(robotHealth, robotPowerLevel, robotWeaponType);
            PopulateFleet(robo);
            return robo;
        }
        public void PopulateFleet(Robot robo)
        {
            fleet.Add(robo);
        }
    }
}
