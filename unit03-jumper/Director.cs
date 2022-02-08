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
        bool gameGoing = true;
        public Director()
        {
            
        }

    /// This runs the Game loop.
        public void StartGame()
        {
            while (isPlaying)
            {
                word.FindRandoNum();
                word.setWord();
                while (jumper.getAlive())
                {
                    Display();
                    UserInterfacing();
                    Updating();
                }
                Console.Write($"Do you want to play again? [y/n] ");
                string playAgain = Console.ReadLine();
                if (playAgain == "y")
                {
                    jumper.setAlive(true);
                }
                else if(playAgain != "y")
                {
                    isPlaying = false;
                }
            }
            Console.WriteLine($"\nThank you for Playing!");
        }
    /// Displays the Jumper and prompts.
        public void Display()
        {
            jumper.display();
        }

    /// User interaction will be handeled here.
        public void UserInterfacing()
        {
            if (!jumper.getAlive())
            {
                return;
            }
            iFace.letterChecker();


    /// This will be commented out.
            Console.Write("Are you still Alive? [y/n]: ");
            string playing = Console.ReadLine();
            if (playing == "y")
            {
                return;
            }
            else
            {
                fails = 5;
            }

        }
    
    /// Asks player if they are still playing, and updating game.
        public void Updating()
        {
            if (jumper.getAlive() == false)
            {
                return;
            }
            isAlive();
            // isPlaying = jumper.getAlive();
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