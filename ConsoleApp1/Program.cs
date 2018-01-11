using System;
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
            //task 1

            Console.WriteLine("Give a number between 1-3: ");
            int numb = Convert.ToInt16(Console.ReadLine());

            if (numb == 1)
                Console.WriteLine("Number is one");
            else if (numb == 2)
                Console.WriteLine("Number is two");
            else if (numb == 3)
                Console.WriteLine("Number is three");
            else if (numb >= 4)
                Console.WriteLine("Wrong number");
            else
            {
                return;
            }



            //task 2


            Console.WriteLine("Give point limit: ");
            int point = Convert.ToInt16(Console.ReadLine());

            if (point <= 1)
                Console.WriteLine("Your grade is 0");
            else if (point <= 3)
                Console.WriteLine("Your grade is 1");
            else if (point <= 5)
                Console.WriteLine("Your grade is 2");
            else if (point <= 7)
                Console.WriteLine("Your grade is 3");
            else if (point <= 9)
                Console.WriteLine("Your grade is 4");
            else if (point <= 12)
                Console.WriteLine("Your grade is 5, " + ("Well done!"));


            //task 3
            double summary;
            double average;
            Console.WriteLine("Give a first number ");
            double first = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Give a second number ");
            double second = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Give a third number ");
            double third = Convert.ToDouble(Console.ReadLine());

            summary = first + second + third;
            average = first + second + third / 3;

            Console.WriteLine("Summary of numbers is: " + summary + ("and average of number is: ") + average);


            //task 4

            Console.Write("Give your age: ");
            int age = Convert.ToInt16(Console.ReadLine());

            if (age < 18)
                Console.WriteLine("You're a minor ");
            if (age >= 18)
                Console.WriteLine("You're a adult");
            if (age >= 66)
                Console.WriteLine("You're a senior");



            //task 5
            int hours;
            int minutes;
            Console.WriteLine("Give number of seconds ");
            int seconds = Convert.ToInt16(Console.ReadLine());


            hours = seconds / 3600;
            seconds = seconds % 3600;
            minutes = seconds / 60;
            seconds = seconds % 60;
            //hours = (int)(Math.Floor((double)(seconds / 3600)));
            //seconds = seconds % 3600;
            //minutes = (int)(Math.Floor((double)(seconds / 60)));
            //seconds = seconds % 60;

            Console.WriteLine("Time can be shown also in " + hours + (":") + minutes + (":") + seconds);
           







            Console.Read();
        }
    }
}
