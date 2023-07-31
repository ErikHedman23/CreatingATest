using System.ComponentModel.Design;

namespace Creatingatest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name here please: ");

            string name = Console.ReadLine();


            Console.WriteLine("Welcome!\n\n");

            Console.WriteLine("First question: \n \n");
            Git();


        }
        public static void Git()
        {
            Console.WriteLine("What is the command in Command Line to create a new file named 'NewFile'");
            string answer = Console.ReadLine();
            bool response = answer == "mkdir NewFile";
            
            while (response == false)
            {
                Console.WriteLine("What is the command in Command Line to create a new file named 'NewFile'.  Try again.");
                answer = Console.ReadLine();
                response = answer == "mkdir NewFile";
            }
            Console.WriteLine("Correct!  Next Question...");
            Console.WriteLine("What is the command for opening that file you just made?");
            var answer_2 = Console.ReadLine();
            var response_2 = answer_2 == "cd NewFile";
            
            while (response_2 == false)
            {
                Console.WriteLine("Try again. What is the command for opening that file you just made?");
                answer_2 = Console.ReadLine();
                response_2 = answer == "cd NewFile";
            }
            Console.WriteLine("Correct. Next question...");

            do
            {
                Console.WriteLine("Initiate your file up to GitHub.");
                var answer_3 = Console.ReadLine();
                var response_3 = answer_3 == "git inti NewFile";
            } while (response_3 == false);




        }


    }
}
