using System;

namespace unit03_jumper
{
    class Director
    {
        bool isPlaying = true;
        Word word = new Word();
        Jumper jumper = new Jumper();
        Interface iFace = new Interface();
        int fails = 0;
        public Director()
        {
            ;
        }

        public void StartGame()
        {
            while (isPlaying)
            {
                Display();
                UserInterfacing();
                Updating();
            }
            Console.WriteLine($"\nThanks for Playing!");
        }
    /// Displays the Jumper and prompts.
        public void Display()
        {
            jumper.display();
            iFace.ask();
        }

    /// User interaction will be handeled here.
        public void UserInterfacing()
        {
            if (!isPlaying)
            {
                return;
            }
            Console.Write("Are you still playing? [y/n]: ");
            string playing = Console.ReadLine();
            if (playing == "y")
            {
                jumper.setAlive(true);
            }
            else
            {
                jumper.setAlive(false);
            }
        }
    
    /// Asks player if they are still playing, and updating game.
        public void Updating()
        {
            if (!isPlaying)
            {
                return;
            }
            isAlive();
            isPlaying = jumper.getAlive();
        }

        public void isAlive()
        {
            if (fails < 5)
            {
                jumper.setAlive(true);
            }
            else
            {
                jumper.setAlive(false);
            }
        }

    }
}