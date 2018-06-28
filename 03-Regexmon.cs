namespace _05_RegexMonByMe
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    class RegexMonByMe
    {
        static void Main()
        {

            var input = Console.ReadLine();
            string patternDidi = @"[^A-Za-z-]+";
            string  patternBojo = @"[A-Za-z]+-[A-Za-z]+";

            var round = 1; //  

            while (true)
            {

                if (round % 2 == 1)
                {
                    if (!Regex.IsMatch(input, patternDidi))
                    {
                        return;
                    }
                    else
                    {
                        Match current = Regex.Match(input, patternDidi);
                        input = input.Substring(current.Index + current.Length);
                        Console.WriteLine(current.ToString());
                    }
                }
                else
                {
                    if (!Regex.IsMatch(input, patternBojo))
                    {
                        return;
                    }
                    else
                    {
                        Match current = Regex.Match(input, patternBojo);
                        input = input.Substring(current.Index + current.Length);
                        Console.WriteLine(current.ToString());
                    }
                }
                round++;

               
            }





        }
    }
}
