using System;

namespace HomeWorkEpam
{
    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;

            while (!endApp)
            {
                string result = "";
                Console.WriteLine("Type your string");
                string simbols = Console.ReadLine();
                result += simbols[0];

                for (int i = 1; i < simbols.Length; i++)
                {
                    if (simbols[i - 1] != simbols[i])
                    {
                        result += simbols[i];
                    }
                }
                Console.WriteLine($"Your string: {result}");

                Console.Write("Press 'q' and Enter to close the app");
                if (Console.ReadLine() == "q") endApp = true;

                Console.WriteLine("\n");
            }
        }
    }
}

