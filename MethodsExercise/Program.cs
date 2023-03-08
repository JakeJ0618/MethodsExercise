using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;
using Microsoft.VisualBasic;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1 

            Console.WriteLine("What is your name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Hi, {userName}, What is your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine($"{color} is one of my favorites too! What is your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine($"{animal}'s are super cool. Now, what is your favorite band?");
            var band = Console.ReadLine();

            //Exercise 2
            Console.WriteLine(Add(35, 68));

             Console.WriteLine(Subtract(17,6));

            Multiply();

            Console.WriteLine(Divide(250, 15));

        }

        public static int Add(int num1, int num2)
        {
            var answer = num1 + num2;

            return answer;
        }
        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }
        public static void Multiply()
        {
            Console.WriteLine("What is the first number you want to multiply");
            var num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("What is the second number?");
            var num2 = int.Parse(Console.ReadLine());

            var answer = num1 * num2;

            Console.WriteLine($"The multiplication answer is {answer}");
        }
            public static int Divide(int num1, int num2)
        {
            var answer = num1 + num2;
            return answer;
        }



        
            
        
        
            
        
            
        }

        
    }

