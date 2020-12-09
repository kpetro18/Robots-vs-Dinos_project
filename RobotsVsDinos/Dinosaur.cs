using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinos
{
    class Dinosaur
    {
        //member variables (HAS A)
        public string dinosaur;
        public string dinosaurType;
        public int dinosaurHealth;
        public int dinosaurEnergyLevel;
        public int dinosaurAttack;

        //constructor (SPAWNER)
        public Dinosaur(string dinosaurType, int dinosaurHealth, int dinosaurEnergyLevel, int dinosaurAttack)
        {
            this.dinosaurType = dinosaurType;
            this.dinosaurHealth = dinosaurHealth;
            this.dinosaurEnergyLevel = dinosaurEnergyLevel;
            this.dinosaurAttack = dinosaurAttack;
        }
        //member methods (CAN DO)

        public void CreateDinosaur(string dinosaurType, int dinosaurHealth, int dinosaurEnergyLevel, int dinosaurAttack)
        {

        }

    }
}
