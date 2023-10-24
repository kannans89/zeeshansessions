using System.Diagnostics.CodeAnalysis;

namespace PassingValuesToFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int score = 100;
            UpdateScoreToZero(ref score);
            Console.WriteLine(score);

            int[] manyScores = { 10, 20, 30, 40 };
            object copy =  manyScores.Clone();
            Console.WriteLine(copy.GetHashCode());
            UpdateManyScoresToZero(manyScores);
            Console.WriteLine($"hash code is {manyScores.GetHashCode()} ");

            foreach (int manyScore in manyScores)
            {
                Console.WriteLine(manyScore);
            }

           // CaseStudyOutputparams();

        }

        private static void CaseStudyOutputparams()
        {
            double sum, avg;
            Calculate(10, 20, 30, out sum, out avg);
            Console.WriteLine($"sum is {sum} and avg is {avg}");

            string userInput = "8";
            int outputResult = 0;
            if (int.TryParse(userInput, out outputResult))
            {
                Console.WriteLine($"success parsed correctly rresult {outputResult * outputResult} ");
            }

            else
            {
                Console.WriteLine("this not valid no to parse");
            }
        }

        private static void Calculate(int v1, int v2, int v3, out double sum, out double avg)
        {

             sum = v1 + v2 + v3;
             avg = sum / 3;
        }

        private static void UpdateManyScoresToZero(int[] manyScores)
        {
            Console.WriteLine($"inside function hashcode of array {manyScores.GetHashCode()} ");
            for (int index=0;index<manyScores.Length;index++) {
                manyScores[index] = 0;
            }
        }

        private static void UpdateScoreToZero(ref int pscore)
        {

            pscore = 0;
        }
    }
}