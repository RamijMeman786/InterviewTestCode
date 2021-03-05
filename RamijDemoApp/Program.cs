using System;

namespace RamijDemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string Inputstr;

            int MaxCount = 0;

            string FrequentCharacter = "";
            string resultCharacter = "";


            Console.Write("Input the string : ");

            Inputstr = Console.ReadLine();

            Console.Write("The string you entered is : {0}\n", Inputstr);


            for (int i = 0; i < Inputstr.Length; i++)
            {
                int Count = 0;

                for (int j = 0; j < Inputstr.Length; j++)
                {
                    if (char.ToUpperInvariant(Inputstr[i]) == char.ToUpperInvariant(Inputstr[j]))
                    {
                        FrequentCharacter = Convert.ToString(Inputstr[i]);
                        Count++;
                    }
                }
                if (Count > MaxCount)
                {
                    resultCharacter = FrequentCharacter;
                    MaxCount = Count;
                }
            }

            Console.Write("Frequent Character:" + resultCharacter);

            Console.Write("\n");

            Console.Write("Count:" + MaxCount);

            Console.ReadLine();
        }
    }
}
