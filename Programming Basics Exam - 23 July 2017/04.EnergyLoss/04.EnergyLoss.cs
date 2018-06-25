using System;

namespace _04.EnergyLoss
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int dancers = int.Parse(Console.ReadLine());

            double wastedEnergy = 0;
            double totalEnergy = 100 * n * dancers;

            for (int trainingDays = 1; trainingDays <=n; trainingDays++)
            {
                int trainingHours = int.Parse(Console.ReadLine());

                //Even training & even hour
                if (trainingDays % 2 == 0 && trainingHours % 2 == 0)
                {
                    wastedEnergy += dancers * 68;
                }
                //Odd training & even hour
                else if (trainingDays % 2 == 1 && trainingHours % 2 == 0)
                {
                    wastedEnergy += dancers * 49;
                }
                //Even training & odd hour
                else if (trainingDays % 2 == 0 && trainingHours % 2 == 1)
                {
                    wastedEnergy += dancers * 65;
                }
                //Odd training & odd hour
                else if (trainingDays % 2 == 1 && trainingHours % 2 == 1)
                {
                    wastedEnergy += dancers * 30;
                }
            }

            double unusedEnergy = totalEnergy - wastedEnergy;
            double unusedEnergyPerDancer = unusedEnergy / dancers / n;

            if (unusedEnergyPerDancer > 50)
            {
                Console.WriteLine($"They feel good! Energy left: {unusedEnergyPerDancer:f2}");
            }
            else
            {
                Console.WriteLine($"They are wasted! Energy left: {unusedEnergyPerDancer:f2}");
            }
        }
    }
}
