﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample205
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1, str2;
            Console.WriteLine("str1=");
            str1 = Console.ReadLine(); // 1つ目の文字列を入力
            Console.WriteLine("str2=");
            str2 = Console.ReadLine(); // 2つ目の文字列を入力
            Console.WriteLine("str1 + str2 = {0}", str1 + str2);
        }
    }
}