using System;

namespace Test5.Core.Services
{
    public class TaylorService : ITaylorService
    {
        public double Calculate(double N, double X)
        {
            double taylor;
            double sum = 0;
            for (int i = 0; i < N; i++)
            {
                taylor = Math.Pow(X, i) / Factorial(i);
                sum += taylor;
            }
            return sum;
        }

        public double Factorial(double n)
        {
            if (n <= 1)
            {
                return 1;
            }

            return n * Factorial(n - 1);
        }

    }
}
