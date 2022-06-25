using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.NetFrameWork1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string heroname = "cop";

            float heroHeigh = 175.7f;

            int heroAge = 26;

            string herosuperpower = "Laser";

            string villainName = "Silva driver";

            float villainHeigh = 159.5f;

            int villainAge = 20;

            string villainSuperPower = "Flashing";

            string villainSuperPowerReplace = villainSuperPower.Replase('Flashing', 'None');
            Console.WriteLine(villainSuperPower);

            Console.WriteLine("My name is {0}, my height is {1}, i am {2} years old and my super power is {3}", heroname, heroHeigh, heroAge, herosuperpower);
            Console.WriteLine("My name is {0}, my height is {1}, i am {2} years old and my super power is {3}", villainName, villainHeigh, villainAge, villainSuperPower);
            Console.Out.WriteLine("Differenc between heroAge and villainAge is {0}", getDifferennce(heroAge, villainAge) );
            Console.ReadKey();
        }
        private static int getDifferennce(int heroAge, int villainAge)
        {
            if (villainAge > heroAge)
            {
                return villainAge - heroAge;
            }
            else
            {
                return heroAge - villainAge;
            }
        }
    }
}
