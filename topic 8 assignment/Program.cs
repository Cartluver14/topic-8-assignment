using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace topic_8_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Random generator = new Random();
            // int randomcolour;
            //List<string> colour = new List<string>();

            // Console.WriteLine("Input 5 colours");

            // for (int i = 0; i < 5; i++)
            // {
            //     Console.WriteLine("Please enter a colour");
            //     colour.Add(Console.ReadLine());
            //


            // }
            //  Console.WriteLine(string.Join(", ",colour));
            // randomcolour = generator.Next(0, colour.Count + 1);
            //  Console.WriteLine();
            // Console.WriteLine("Press enter to print random colour");
            //Console.ReadLine();
            //Console.WriteLine(colour[randomcolour] + ". ");


            //Console.ReadLine();



            int numbers;
            int max;
            int min;
            List<int> number = new List<int>();
            Random generator = new Random();
            Console.WriteLine(" how many numbers would you like");
            numbers = int.Parse(Console.ReadLine());
            Console.WriteLine("What do you want the max value to be");
            int.TryParse(Console.ReadLine(), out max);
            Console.WriteLine("what do you want the min value to be");
            int.TryParse(Console.ReadLine(), out min);
            for (int i = 0; i <numbers;i++)
            {
              number.Add(generator.Next(min, max + 1));
                Console.Write(number[i] + ", ");

            }
            Console.ReadLine();
           






        }
    }
}
