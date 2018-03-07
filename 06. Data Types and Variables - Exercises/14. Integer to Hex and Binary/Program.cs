﻿using System;

namespace _14._Integer_to_Hex_and_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int decimalNumber = int.Parse(Console.ReadLine());
            string hexString = Convert.ToString(decimalNumber, 16).ToUpper();
            string binaryString = Convert.ToString(decimalNumber, 2).ToUpper();
            Console.WriteLine($"{hexString}\n{binaryString}");
        }
    }
}
