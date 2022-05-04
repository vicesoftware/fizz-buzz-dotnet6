using System;

namespace ViceSoftware.Services
{
    public class PrimeService
    {
        public bool IsPrime(int candidate)
        {
            int i;  
            for (i = 2; i <= candidate - 1; i++)  
            {  
                if (candidate % i == 0)  
                {  
                    return false;  
                }  
            }  
            if (i == candidate)  
            {  
                return true;  
            }  
            return false;
        }
    }
}