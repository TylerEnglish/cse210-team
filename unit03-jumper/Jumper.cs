using System;
using System.Collections.Generic;

namespace unit03_jumper
{
    class Jumper
    {
        private List<string> parachute = new List<string>();
        private string aliveLilman = ("  O \n /|\\ \n / \\ \n");
        private string deadLilman = ("   X \n  /|\\ \n  / \\ \n");
        private bool isAlive = true;
        public Jumper()
        {
        }

    /// This function displays the Jumper.
        public void display()
        {
            // Placeholder output for displaying word
            Console.WriteLine($"_ _ _ _ _ \n");

            for (int i = 0; i < parachute.Count; i++)
            {
                Console.WriteLine(parachute[i]);
            }

            if (isAlive)
            {
                Console.Write($"{aliveLilman}\n");  
            } 
            else
            {
                Console.Write($"{deadLilman}\n");
            }
            Console.Write("\n^^^^^^^^\n");

        }
        
// Setter for Alive

        public void setAlive(bool alive)
        {
            isAlive = alive;
        }

        public void setParachute()
        {
            parachute.Add(" ____");
            parachute.Add("/____\\");
            parachute.Add("\\    /");
            parachute.Add(" \\  /");
        }
        public List<string> getParachute()
        {
            return parachute;
        }

// Getter for Alive

        public bool getAlive()
        {
            return isAlive;
        }
    }
}
