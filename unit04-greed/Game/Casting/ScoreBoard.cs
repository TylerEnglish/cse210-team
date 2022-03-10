namespace Unit04.Game.Casting
{
    public class ScoreBoard: Actor
    {
        private int points = 0;
        Point point = new Point(0, 0);
        


        public ScoreBoard()
        {
            SetText($"Sccorboard: {points}");
            SetPosition(point);
        }

        public void AddPoints(int points)
        {
            this.points += points;
            SetText($"Sccorboard: {this.points}");

        }
        
    }
}