namespace AnotherExam_pokemon1
{
    using System;

    class Pokemon1
    {
        static void Main()
        {
           
            int powerN = int.Parse(Console.ReadLine());
            int distanceM = int.Parse(Console.ReadLine());
            int exhaustionFactorY = int.Parse(Console.ReadLine());
            int counter = 0;
            int currentPower = powerN;

            while (currentPower >= distanceM)
            {
                currentPower -= distanceM;
                counter++;

                if (currentPower == powerN/2 && powerN % 2 == 0 && exhaustionFactorY != 0)
                {
                    currentPower /= exhaustionFactorY;
                }
          }
          
            Console.WriteLine(currentPower);
            Console.WriteLine(counter);
        }
    }
}
