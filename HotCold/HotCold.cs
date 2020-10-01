using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotCold
{
    class HotCold
    {
        public static void posCheck()
        {
            //needs updates
            double cursX = 20;
            double cursY = 20;
            double pointX = 1;
            double pointY = 1;


            double difficulty = 1;
            int easy = 25;
            int medium = 12;
            int hard = 5;
            int extreme = 1;

            double distance = Math.Floor(Math.Sqrt(Math.Pow(cursX - pointX,2) + Math.Pow(cursY - pointY,2)));

            //choose difficulty
            Console.WriteLine("Choose a difficulty. 1:Easy 2:Medium 3:Hard 4:Extreme. Please enter a number");
            int difChoice = Convert.ToInt32(Console.ReadLine());

            //sets difficulty
            switch (difChoice)
            {
                case 1:
                    difficulty = easy;
                    break;
                case 2:
                    difficulty = medium;
                    break;
                case 3:
                    difficulty = hard;
                    break;
                case 4:
                    difficulty = extreme;
                    break;
            }

            //checks where cursur is and says where it is
            if (distance > 400)
            {
                Console.WriteLine("Frozen");
            }
            else if (distance >= 200)
            {
                Console.WriteLine("Ice Cold");
            }
            else if (distance >= 100)
            {
                Console.WriteLine("Cold");
            }
            else if (distance >= 50)
            {
                Console.WriteLine("Warm");
            }
            else if (distance >= 30)
            {
                Console.WriteLine("On Fire");
            }
            else if (distance >= difficulty)
            {
                Console.WriteLine("Hit");
            }


        }
    }
}
