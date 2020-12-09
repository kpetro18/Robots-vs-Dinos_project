using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinos
{
    class Robot
    {
        //member variables (HAS A)
        public string robot;
        public int robotHealth;
        public int robotPowerLevel;
        public string robotWeaponType;

        //constructor (SPAWNER)
        public Robot(int robotHealth, int robotPowerLevel, string robotWeaponType)
        {
            this.robotHealth = robotHealth;
            this.robotPowerLevel = robotPowerLevel;
            this.robotWeaponType = robotWeaponType;
        }
        //member methods (CAN DO)


    }
}
