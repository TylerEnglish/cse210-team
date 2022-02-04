using System;

namespace unit03_jumper
{
    class Interface
    {
        private string letterGuess = "";
        public Interface()
        {
            ;
        }

        public void ask()
        {
            Console.Write($"Guess a Letter [a-z]: ");
            letterGuess = Console.ReadLine();
        }
        
        public string getGuess()
        {
            return letterGuess;
        }
    }
}