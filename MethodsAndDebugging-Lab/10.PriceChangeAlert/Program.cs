using System;

namespace _10.PriceChangeAlert
{
    class Program
    {
        static void Main()
        {
            int numberOfPrise = int.Parse(Console.ReadLine());
            double threshold = double.Parse(Console.ReadLine());
            double firstPrice = double.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfPrise - 1; i++)
            {
                double currentPrice = double.Parse(Console.ReadLine());
                double div = Proc(firstPrice, currentPrice);
                bool isSignificantDifference = HasDif(div, threshold);
                string message = GetMessage(currentPrice, firstPrice, div, isSignificantDifference);
                Console.WriteLine(message);
                firstPrice = currentPrice;
            }
        }

        private static string GetMessage(double c, double last, double razlika, bool etherTrueOrFalse)
        {
            string to = "";
            if (razlika == 0)
            {
                to = string.Format("NO CHANGE: {0}", c);
            }
            else if (!etherTrueOrFalse)
            {
                to = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", last, c, razlika);
            }
            else if (etherTrueOrFalse && (razlika > 0))
            {
                to = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", last, c, razlika);
            }
            else if (etherTrueOrFalse && (razlika < 0))
            {
                to = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", last, c, razlika);
            }
            return to;
        }
        private static bool HasDif(double granica, double isDiff)
        {
            if (Math.Abs(granica) >= isDiff)
            {
                return true;
            }
            return false;
        }

        private static double Proc(double firstPrice, double currentPrice)
        {
            double r = (currentPrice - firstPrice) / firstPrice;
            return r;
        }
    }
}
