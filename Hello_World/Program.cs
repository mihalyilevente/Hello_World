﻿using System;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
           for (int i = 0; i < 5; i++) { Console.WriteLine("Sleep for 2 seconds."); Thread.Sleep(10000); } Console.WriteLine("Main thread exits.");
        }
    }
}
