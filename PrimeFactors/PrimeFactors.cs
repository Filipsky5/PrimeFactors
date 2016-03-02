﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFactors
{
    public class PrimeFactors
    {
        public static List<int> ComputeFactors(int i)
        {
            List<int> primeFactors = new List<int>();
            
            for(int candidate = 2;i> 1;candidate++) { 
                for(;i%candidate == 0; i /= candidate) { 
                    primeFactors.Add(candidate);
                }



                
            }
            return primeFactors;
        }
    }
}
