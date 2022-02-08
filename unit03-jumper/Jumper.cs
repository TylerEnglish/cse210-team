using System;
using System.Collections.Generic;

namespace unit03_jumper
{
    class Jumper
    {
        private List<string> parachute = new List<string>();
        private string aliveLilman = ("  O \n /|\\ \n / \\ \n");
        private string deadLilman = ("  X \n /|\\ \n / \\ \n");
        private bool isAlive = true;
        public Jumper()
        {
        }

    /// This function displays the Jumper.
        public void display()
        {
            // Placeholder output for displaying word
            Console.WriteLine($"_ _ _ _ _ ");
            // Placeholder output for displaying jumper
            Console.Write($"\n{aliveLilman}\n");

            Console.Write("\n^^^^^^^^\n");
            // Console.Write($"  O \n");
            // Console.Write($" /|\ \n");
            // Console.Write($" / \ \n");

        }
        
// Setter for Alive

        public void setAlive(bool alive)
        {
            isAlive = alive;
        }

// Getter for Alive

        public bool getAlive()
        {
            return isAlive;
        }
    }
}
