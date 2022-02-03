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
            ;
        }

        public void StartGame()
        {
            while (isPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }

        public void GetInputs()
        {
            ;
        }

    /// Updates
        public void DoUpdates()
        {
            if (!isPlaying)
            {
                return;
            }
        }
    
    /// Asks player if they are still playing.
        public void DoOutputs()
        {
            if (!isPlaying)
            {
                return;
            }
        }

    }
}