using System;
using System.Collections.Generic;

namespace TS1
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice, str;
            bool cont = true;
            do
            {

                do
                {
                    Console.WriteLine("1- Start");
                    Console.WriteLine("2- Exit");
                    choice = Console.ReadLine();

                } while (choice != "1" && choice != "2");

                if (choice == "2")
                    return;
                else
                {
                    Console.WriteLine("Can you write the string!");
                    str = Console.ReadLine();
                    while (str.Length == 0)
                    {
                        Console.WriteLine("wrong format or empty ! Can you rewrite the string!");
                        str = Console.ReadLine();
                    }
                    Dictionary<char, int> reccurences = new Dictionary<char, int>();
                    int i = 0;
                    while (i < str.Length)
                    {
                        if (str[i] != ' ')
                        {
                            reccurences.TryGetValue(str[i], out var c);
                            reccurences[str[i]] = c + 1;
                        }
                        i++;
                    }

            
                    foreach(var x in reccurences)
                    {
                        if (x.Value >= 2)
                            Console.Write(x.Key + " occurs " + x.Value + " times,");
                       
                    }

                    Console.WriteLine("try again ? O/N");
                    string ch = Console.ReadLine();
                    if (ch == "N")
                        cont = false;
                }

            } while (cont);
        }
    }
}
