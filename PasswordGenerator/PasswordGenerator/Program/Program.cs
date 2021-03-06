﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PasswordGenerator;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("The password generation by: PasswordGenCrypto.");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(PasswordGenCrypto.PassGen(16));
            }
            Console.WriteLine();
            Console.WriteLine("The password generation by: PasswordGenCryptoBit.");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(PasswordGenCryptoBit.PassGen(32));
            }
            Console.WriteLine();
            Console.WriteLine("The password generation by: PasswordGenRandom.");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(PasswordGenRandom.PassGenRand(32));
            }


            Console.ReadKey();
        }
    }
}
