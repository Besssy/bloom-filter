using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Security.Cryptography;

namespace Krypto3
{
    class BloomFilter
    {
        const int m = 1000;     // size of bit arrray
        const int k = 10;       // number of hash functions
        BitArray bloomfilter = new BitArray(m);

        private int[] kHashValues(string s, int k)          // hash values
        {
            int[] hashes = new int[k];
            hashes[0] = Math.Abs(s.GetHashCode());
            Random R = new Random(hashes[0]);
            for (int i = 1; i < k; i++)
            {
                hashes[i] = R.Next();
            }
            return hashes;
        }

        public void AddData(string s)           //add data from input
        {
            int[] hashes = kHashValues(s, k);
            for (int i = 0; i < k; i++)
            {
                bloomfilter.Set(hashes[i] % m, true);
            }
        }

        public Boolean SearchValue(string s)        //confirm if data exist
        {
            int[] hashes = kHashValues(s, k);
            for (int i = 0; i < k; i++)
            {
                if (bloomfilter[hashes[i] % m] == false)
                    return false;
            }
            return true;
        }

       
    }
}
