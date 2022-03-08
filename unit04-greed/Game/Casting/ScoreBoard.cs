namespace Unit04.Game.Casting
{
    public class ScoreBoard: Actor
    {
        private int points;
        Point point = new Point(0, 0);


        public ScoreBoard()
        {
            // SetText($"{points}");

        }

        public void AddPoints(int points)
        {
            this.points += points;
        }
        
    }
}