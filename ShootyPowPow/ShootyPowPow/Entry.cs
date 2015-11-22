using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShootyPowPow
{
    class Entry
    {

        static void Main(string[] args)
        {
            try
            {
                using (Game1 game = new Game1())
                {
                    game.Run();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed To Start Program" + "\n \n" + ex.Message + "\n \n" + ex.InnerException);
            }

        }
    }
}
