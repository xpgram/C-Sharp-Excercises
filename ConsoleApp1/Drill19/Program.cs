﻿using System;
using System.Collections.Generic;

namespace Drill19
{
    static class Program
    {
        public static void run()
        {
            IQuittable guy = new Employee() {
                FirstName = "Sample",
                LastName = "Student",
                id = 13
            };

            guy.Quit();

            Console.Read();
        }

        static string StringPrompt(string msg)
        {
            Console.WriteLine(msg);
            Console.Write("> ");
            return Console.ReadLine();
        }

        static int IntPrompt(string msg)
        {
            bool success = false;
            int n = 0;

            do {
                Console.WriteLine(msg);
                Console.Write("> ");
                try {
                    n = Convert.ToInt32(Console.ReadLine());
                    success = true;
                }
                catch (FormatException e) {
                    Console.WriteLine(e.Message);
                }
            } while (!success);

            return n;
        }
    }
}
