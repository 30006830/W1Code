﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace y_e_e_t__t_h_i_s__f_i_l_e
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Yellow;

            int age;
            string name;

            Console.WriteLine("Chur bro, Enter your age: "); //asks for your name after greeting you
            age = int.Parse(Console.ReadLine()); //this parses your age as an integer for use

            Console.WriteLine("What's your name? "); //asks for your name
            name = Console.ReadLine();

            //this will prompt a message that will say "nice to meet you, <your name here>"
            Console.Write("Nice to meet you, ");          
            Console.WriteLine(name);
        
            //you can reply if you want, if not press enter to the next message
            Console.ReadLine(); 
            
            //this will prompt a message that will say "your age is approximately, <the age you entered>
            Console.Write("Your age is approximately, "); 
            Console.WriteLine(age);
            
            //same as the first time reply how you wish if you want. if not press enter to continue
            Console.ReadLine(); 
            
            //program replies before user presses enter or replies to close down command prompt
            Console.Write("It was nice speaking to you, "); 
            Console.WriteLine(name);

            Console.WriteLine("Goodbye!");

            Console.ReadLine();
        }
    }
}
