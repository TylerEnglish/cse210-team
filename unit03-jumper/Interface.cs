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

// Ask user what letter they guess.
        public void ask()
        {
            Console.Write($"Guess a Letter [a-z]: ");
            letterGuess = Console.ReadLine();
        }
        
// Getter for Guess

        public string getGuess()
        {
            return letterGuess;
        }
    }
}