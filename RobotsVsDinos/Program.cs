using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinos
{
    class Program
    {
        static void Main(string[] args)
        {
            Battlefield battlefield = new Battlefield();
            battlefield.CreateDino("typeOne", 100, 100, 10);
            battlefield.CreateDino("typetwo", 200, 200, 20);
            battlefield.CreateDino("typeThree", 300, 300, 30);
        }
    }
}
