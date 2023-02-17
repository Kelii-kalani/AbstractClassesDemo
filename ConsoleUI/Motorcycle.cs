using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Motorcycle : Vehicle
    {
        public string HasTwoWheels { get; set; }
        public override void DriveAbstract()
        {
            Console.WriteLine("crotch rocket");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("Like lightning");
        }
    }
}
