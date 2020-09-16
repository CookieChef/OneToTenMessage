using System;

namespace OneToTenMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) {
                Console.WriteLine("Enter a number between 1 and 10");
                var userNum = Int32.Parse(Console.ReadLine());
                while(userNum > 0) {
                    Console.WriteLine("Good Job!");
                    userNum --;
                }
            }
        }
    }
}
