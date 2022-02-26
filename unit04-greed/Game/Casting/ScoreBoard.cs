namespace Unit04.Game.Casting
{
    public class ScoreBoard: Actor
    {
        private int points;

        public ScoreBoard()
        {
        }

        public void AddPoints(int points)
        {
            this.points += points;
        }
        
    }
}