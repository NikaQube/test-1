﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("write the number you want to find: ");
            string pretarget = Console.ReadLine();
            int target = Int32.Parse(pretarget);
            int[] array = list.ToArray(2, 4, 5, 7);
            int i = 0;
            while (i < list.Count)
            {
                int a = list.ElementAt(i);
                if (a == target)
                {
                    Console.WriteLine("true " + list.IndexOf(a));
                    i = list.Count;
                }
                else
                {
                    Console.WriteLine("false " + list.IndexOf(a));
                    
                }
                
                Console.ReadKey();
            }
        }
    }
}
