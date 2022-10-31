using System;

namespace StringExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, please insert the request information: ");
            Console.WriteLine("Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("heigth: ");
            int heigth = Convert.ToInt32(Console.ReadLine());
            string information = "Hello " + name 
                + " your data is: \n UserName: " + name 
                + "\n Age: "+ age + "y/o"
                + "\n Heigth: " + heigth + "cm";
            Console.WriteLine(information);
        }
    }
}