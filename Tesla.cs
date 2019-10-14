using System;

namespace Inheritance_Intro {
        public class Tesla : Vehicle {  // Electric car
        public double BatteryKWh { get; set; }

        public void ChargeBattery () {}

        

        public override void Drive()
        {
            Console.WriteLine("The Tesla goes shooosh!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Tesla reached the drive and turned {direction}.");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Tesla blew away the competition in 0-60 and quickly slammed on the brakes.");
        }
    }

      
}