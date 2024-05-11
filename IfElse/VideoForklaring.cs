using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElse
{
    internal class VideoForklaring
    {
        int number = 5;
        int number2 = 5;
        bool isEqual = false;

        public void Run()
        {
            if (number == number2)
            {
                isEqual = true;
                Console.WriteLine("The numbers are equal");
            }
            else
            {
                isEqual = false;
                Console.WriteLine("The numbers are not equal");
            }

            if (isEqual)
            {
                number++;
            }
            else
            {
                number2--;
            }

        }
    }
}
