using System;
using System.Linq;

namespace EpamHomeWork
{
    class ConvertNumbers
    {
        static void Main(string[] args)
        {
            string conversion = "";
            
            Console.WriteLine("Type number and press Enter");
            var number = int.Parse(Console.ReadLine());

            Console.WriteLine("Type another number from 2 to 20 and press Enter");
            var baseNumber = int.Parse(Console.ReadLine());

            if (baseNumber < 2 || baseNumber > 20)
            {
                throw new ArgumentException("Please type number from 2 to 20.");
            }
            
            while (number != 0 && baseNumber >= 2 && baseNumber <= 20)
            {
                conversion += Convert.ToString(number % baseNumber);
                number = number / baseNumber;
            }

            var conversion2 = conversion.ToArray().Reverse();
            Console.WriteLine("Your convert number :");
            Console.Write(string.Join("", conversion2));
        }
    }
}