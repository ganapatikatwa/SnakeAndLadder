using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class InitialPosition
    {
        public  void dierollposition()
        {
            int position = 0;
            int dieroll = 0;
            Console.WriteLine("Initial Position of Player1 is--"+position);
            Random random= new Random();
            dieroll = random.Next(1, 7);
            Console.WriteLine("The Number Gets from Die Roll is --"+dieroll);
            position = dieroll;
            Console.WriteLine("The Position of Player After Die Roll is--"+position);
        }
    }
}
