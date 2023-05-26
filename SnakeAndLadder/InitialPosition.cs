using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class InitialPosition
    {
        public const int ladder = 1;
        public const int snake = 2;
        public const int winposition = 100;

        public  void dierollposition()
        {
            int position = 0;
            int dieroll = 0;
            Console.WriteLine("Initial Position of Player1 is--"+position);
            while (position <winposition)
            {
                Random random = new Random();
                dieroll = random.Next(1, 7);
                //Console.WriteLine("The Number Gets from Die Roll is --" + dieroll);
                //position = dieroll;
                //Console.WriteLine("The Position of Player After Die Roll is--" + position);

                int option = random.Next(0, 3);
                //Console.WriteLine("The Option is--" + option);
                switch (option)
                {
                    case ladder:
                        Console.WriteLine("The Option We get Ladder");
                        position += dieroll;
                        Console.WriteLine("New Position After Getting Ladder--" + position);
                        if(position>100)
                        {
                            position = 100;
                        }
                        break;
                    case snake:
                        Console.WriteLine("The option player bite by Snake");
                        position -= dieroll;
                        Console.WriteLine("New Position After Bite by Snake--" + position);
                        break;

                        if (position < 0)
                        {
                            position = 0;
                            Console.WriteLine("The Player Start from Initial Position after Snake Bite--" + position);
                        }
                        break;

                    default:
                        Console.WriteLine("The option We got no Play and present Position is--" + position);
                        break;
                }
                Console.WriteLine("Current position of the Palyer is--"+position);
                if (position > 100)
                {
                    position -= dieroll;
                    Console.WriteLine("Previous Position:" + position);

                }
            }

            Console.WriteLine("Player wins the gamr at 100 th position--" + position);

        }
    }
}
