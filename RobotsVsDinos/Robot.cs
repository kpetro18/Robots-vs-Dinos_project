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
        public string robotName;
        public int robotHealth;
        public int robotPowerLevel;
        public string robotWeaponType;
        List<Weapon> robotWeapons;

        //constructor (SPAWNER)
        public Robot(string robotName, int robotHealth, int robotPowerLevel, string robotWeaponType)
        {
            this.robotName = robotName;
            this.robotHealth = robotHealth;
            this.robotPowerLevel = robotPowerLevel;
            this.robotWeaponType = robotWeaponType;
            this.robotWeapons = new List<Weapon>();
        }
        //member methods (CAN DO)


    }
}
