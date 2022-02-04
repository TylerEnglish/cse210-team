using System;

namespace unit03_jumper
{
    class Jumper
    {
        string lilman = " Jumper";
        public Jumper()
        {
            ;
        }

    /// This function displays the Jumper.
        public void display()
        {
            // Placeholder output for displaying word
            Console.WriteLine($"_ _ _ _ _ ");
            // Placeholder output for displaying jumper
            Console.Write($"\n{lilman}\n");

            Console.Write("\n^^^^^^^^\n");
            // Console.Write($"  O \n");
            // Console.Write($" /|\ \n");
            // Console.Write($" / \ \n");

        }
    }
}
