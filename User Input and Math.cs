using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
 // Compiler version 4.0, .NET Framework 4.5


 namespace Dcoder
 {
   public class Program
   {
     public static void Main(string[] args)
     {
       try
       {
       Console.WriteLine("Hello, please enter your name below!");
       string name = Console.ReadLine();
       Console.WriteLine("Hello " + name);
       Console.WriteLine("How many chocolates you want? Write below!");
       double chocolate = Convert.ToInt32(Console.ReadLine());
       Console.WriteLine("You followed all things correctly and you will get 5 more chocolates!");
       Console.WriteLine("Now you have: " + (chocolate + 5) + " Chocolates");
       }
       catch (Exception e)
       {
         Console.WriteLine($"An error occurred see below for more information: \n [ERROR] : {e}");
       }
     }
   }
 }
