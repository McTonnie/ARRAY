using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARRAY
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[9];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i + 1;
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i + 1 == 5)
                {
                    //vidste ikke lige om det det dobelte af plads nr 5 (index 4) eller om den fra index 3 så jeg valgte den med index 3

                    numbers[i] = numbers[i - 1] * 2;

                    //eller ville det se sådan her ud kun en af dem skal bruges
                    numbers[i] = numbers[i] * 2;
                }
            }
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.ReadKey();
        }
    }
}
