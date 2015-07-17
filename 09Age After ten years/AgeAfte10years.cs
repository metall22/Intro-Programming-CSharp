using System;




    class AgeAfte10years
    {
        static void Main(string[] args)

        {
            //I'll apreciate it if somebody tells me where my mistake is 
            
          Console.Write("Enter your birth date: Month/Day/Year:");
          DateTime Birthday=DateTime.Parse(Console.ReadLine());
          int age=(int)((DateTime.Now-Birthday).TotalDays/365.242199);
            Console.WriteLine("You are"+age+"year(s) old");
            Console.WriteLine("After ten years you will be at the age of "+(age+10));
        }
    }

