using System;

namespace _04.ExternalEvaluation
{
    class Program
    {
        static void Main()
        {
            int students = int.Parse(Console.ReadLine());

            double poorMark = 0;
            double satisfactoryMark = 0;
            double goodMark = 0;
            double veryGoodMark = 0;
            double excellentMark = 0;

            for (int i = 0; i < students; i++)
            {
                double grades = double.Parse(Console.ReadLine());
                if (grades < 22.5)
                    poorMark++;
                else if (grades == 22.5 || grades <= 40.5)
                    satisfactoryMark++;
                else if (grades == 40.5 || grades <= 58.5)
                    goodMark++;
                else if (grades == 58.5 || grades <= 76.5)
                    veryGoodMark++;
                else if (grades == 76.5 || grades <= 100)
                    excellentMark++;
            }
            //Finding the percentage for each mark.
            double resultPM = poorMark / students * 100;
            double resultSM = satisfactoryMark / students * 100;
            double resultGM = goodMark / students * 100;
            double resultVGM = veryGoodMark / students * 100;
            double resultEM = excellentMark / students * 100;

            Console.WriteLine($"{resultPM:f2}% poor marks");
            Console.WriteLine($"{resultSM:f2}% satisfactory marks");
            Console.WriteLine($"{resultGM:f2}% good marks");
            Console.WriteLine($"{resultVGM:f2}% very good marks");
            Console.WriteLine($"{resultEM:f2}% excellent marks");
        }
    }
}
