using System;
using System.ComponentModel.DataAnnotations;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            Console.WriteLine("What is your favorite color?");
            var color = Console.ReadLine();
            Console.WriteLine("What is your favorite Animal?");
            string animal = Console.ReadLine();
            Display display = new Display();
            string result = display.DisplayInfo(name, color, animal);
            Console.WriteLine(result);
        }


    }
    public class Display
    {
        internal string DisplayInfo(string name, string color, string animal)
        {
            return $"My name is {name}, and my favorite color is {color}.  My Spirit animal is the {animal}cd";
        }
    }

}
