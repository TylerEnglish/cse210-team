using System;

namespace unit03_jumper
{
    class Word
    {
        private string currentWord = "";
        private string guess = "";
        private int randoNum = 0;

        public Word()
        {

        }
    // Creates a random number to select a word from the list.
        public void FindRandoNum()
        {
            Random random = new Random();
            randoNum = random.Next(1,5);
        }

        public void checkWord(string UserGuess)
        {
            for (int i = 0; i < 1 ; i++)
            {
                if (currentWord[i] == UserGuess[0])
                {
                    // This checks each letter of the word to see if it 
                    // matches the guessed letter.
                }
            };
        }

        public void setGuess(string guess)
        {  
            this.guess = guess;
        }

        public string getGuess()
        {
            return guess;
        }

        public void setWord(string word)
        {  
            currentWord = word;
        }

        public string getWord()
        {
            return currentWord;
        }

        public int getRandoNum()
        {
            return randoNum;
        }

    }
}