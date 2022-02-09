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
            
        }

        public void StartGame()
        {
            word.FindRandoNum();
            word.setWord();
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
            jumper.setParachute();
            jumper.display();
        }

    /// User interaction will be handeled here.
        public void UserInterfacing()
        {
            if (!isPlaying)
            {
                return;
            }
            iFace.ask();


    /// This will be commented out.
            Console.Write("Are you still playing? [y/n]: ");
            string playing = Console.ReadLine();
            if (playing == "y")
            {
                return;
            }
            else
            {
                isPlaying = false;
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

// Check if the Jumper is alive.
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

        // This Checks each letter of the word to see if it matches the guessed letter.
        public void checkWord(string UserGuess)
        {
            for (int i = 0; i < word.getWordCount() + 1; i++)
            {
                if (word.getWord()[i] == UserGuess[0])
                {

                }
            };
        }

    }
}