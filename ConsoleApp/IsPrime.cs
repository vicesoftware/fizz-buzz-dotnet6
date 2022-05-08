using System;

namespace ViceSoftware.Services
{
    public class PrimeService
    {
        /*
            IsPrime is named like it should return a boolean, 
            but returning a string makes sense with the current fizzbuzz algorithm
            together with the note about adding more math in future 
            requirements. If anything, I would keep the extensibility
            of fizzbuzz and change the name of IsPrime.
        */
        public string IsPrime(int candidate)
        {
            if (candidate <= 1) return candidate.ToString();
            if (candidate == 2) return "Quartz";
            if (candidate % 2 == 0) return candidate.ToString();

            var boundary = (int)Math.Floor(Math.Sqrt(candidate));

            for (int i = 3; i <= boundary; i+=2)
                if (candidate % i == 0)
                    return candidate.ToString();

            return "Quartz";        
        }

    }
}