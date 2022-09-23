using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0, sumScore = 0;

            while (true)
            {
                try
                {
                    Console.Write("enter student score: ");
                    string studentScore = Console.ReadLine();

                    int numberScore = int.Parse(studentScore);

                    if ((numberScore >= 0) && (numberScore <= 20))
                    {
                        sumScore += numberScore;
                        counter++;
                        continue;
                    }
                    else
                        break;
                }
                catch (Exception)
                {
                    Console.WriteLine("General exception! Please enter valid number between 0 - 20.");
                }
            }
            Console.WriteLine("Avrage student's score is {0}", sumScore/counter);

            Console.Read();
        }
    }
}
