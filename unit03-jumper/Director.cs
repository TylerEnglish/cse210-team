using System;

namespace unit03_jumper
{
    class Director
    {
        bool isPlaying = true;
        Word word = new Word();
        Jumper jumper = new Jumper();
        Interface iFace = new Interface();
        public Director()
        {
            
        }

        public void StartGame()
        {
            while (isPlaying)
            {
                Display();
                UserInterfacing();
                Updating();
            }
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

        }
    
    /// Asks player if they are still playing, and updating game.
        public void Updating()
        {
            if (!isPlaying)
            {
                return;
            }
        }

    }
}