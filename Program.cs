namespace Assignment5._3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalSteps = 5;
            Console.WriteLine(MaxCombinationOfSteps(totalSteps));
        }

        static int MaxCombinationOfSteps(int steps)
        {
            if (steps <= 1)
            {
                return 1;
            }

            return MaxCombinationOfSteps(steps - 1) + MaxCombinationOfSteps(steps - 2);
        }
    }
}





