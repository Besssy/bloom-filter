using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Krypto3
{
    class Program
    {
        static void Main(string[] args)
        {
            BloomFilter bloom = new BloomFilter();

            Console.WriteLine("Insert your elements:");
            string element = Console.ReadLine();
            bloom.AddData(element);
            Console.WriteLine("Check if the element exists \n" + bloom.SearchValue(element).ToString());

            Console.ReadKey();  
        }
    }
}
