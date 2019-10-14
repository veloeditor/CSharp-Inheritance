using System;

namespace Inheritance_Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            Ram ram1 = new Ram();
            Tesla modelS = new Tesla();
            Cessna mx410 = new Cessna();

            fxs.Drive();
            modelS.Drive();
            mx410.Drive();
            ram1.Drive();

            fxs.MainColor = "smoke-gray";
            ram1.MainColor = "yellow";
            modelS.MainColor = "silver";
            mx410.MainColor = "white";

            fxs.Stop();
            modelS.Stop();
            mx410.Stop();
            ram1.Stop();

            fxs.Turn("left");
            modelS.Turn("right");
            mx410.Turn("left");
            ram1.Turn("right");

        }


    }
}
