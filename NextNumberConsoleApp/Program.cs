﻿using System;

namespace NextNumberConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"          F1124   {Helpers.NextValue("F1124")}");
            Console.WriteLine($"       1278-120   {Helpers.NextValue("1278-120")}");
            Console.WriteLine($"           F102   {Helpers.NextValue("F102")}");
            Console.WriteLine($"3999/IKL/VII/21   {Helpers.NextValue("3999/IKL/VII/21")}");
            Console.ReadLine();
        }
    }
}
