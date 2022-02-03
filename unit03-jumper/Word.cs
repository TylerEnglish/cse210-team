using System;

namespace unit03_jumper
{
    class Word
    {
        private string currentWord;
        private string guess;
        private int randoNum;
        public Word()
        {

        }

        public void FindRandoNum()
        {
            Random random = new Random();
            randoNum = random.Next(1,5);
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


    }
}