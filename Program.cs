using System;

namespace _7._3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Processor proc = new Processor();
            MotherBoard mot = new MotherBoard();
            GraphicCard gc = new GraphicCard();


        }

        abstract class ComputerPart
        {
            public abstract void Work();
        }

        class Processor : ComputerPart
        {
            public override void Work()
            {
                Console.WriteLine("Processor");
            }
        }

        class MotherBoard : ComputerPart
        {
            public override void Work()
            {
                Console.WriteLine("MotherBoard");
            }
        }

        class GraphicCard : ComputerPart
        {
            public override void Work()
            {
                Console.WriteLine("GraphicCard");
            }
        }
    }
}
