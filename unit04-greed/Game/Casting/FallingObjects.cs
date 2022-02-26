using System;
namespace Unit04.Game.Casting
{
    public class FallingObject: Actor
    {
        private int value;

        public FallingObject()
        {
            Random randomGen = new Random();
            int randX = randomGen.Next(0, 1000);
            int ySpeed = randomGen.Next(1,14);
            Point point = new Point(randX, 0);
            Point velocity = new Point(GetPosition().GetX(), ySpeed);
            SetPosition(point);
            SetVelocity(velocity);
        }


        public void SetValue(int value)
        {
            this.value = value;
        }

        public int GetValue()
        {
            return value;
        }
    }
}