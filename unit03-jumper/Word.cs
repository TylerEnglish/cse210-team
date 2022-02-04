using System;
using System.Collections.Generic;

namespace unit03_jumper
{
    class Word
    {
        private List<string> words = new List<string>();
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
            randoNum = random.Next(0,words.Count + 1 );
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

// Setter for Guess
        public void setGuess(string guess)
        {  
            this.guess = guess;
        }

// Getter for Guess
        public string getGuess()
        {
            return guess;
        }

// Setter for Word
        public void setWord(string word)
        {  
            currentWord = word;
        }

// Getter for Word

        public string getWord()
        {
            return currentWord;
        }

// Getter for RandoNum

        public int getRandoNum()
        {
            return randoNum;
        }

    }
}