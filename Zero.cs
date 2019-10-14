using System;

namespace Inheritance_Intro {
    public class Zero : Vehicle {  // Electric motorcycle
        public double BatteryKWh { get; set; }

        public void ChargeBattery () {}

        public override void Drive()
        {
            Console.WriteLine("The Zero goes vrooom!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Zero reached the intersection and turned {direction}.");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Zero reached its parking spot and rolled to a stop.");
        }
    }
}