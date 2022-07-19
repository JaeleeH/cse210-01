//Jaelee

using System;


namespace cycle.Game.Casting
{
    /// A tasty item that snakes like to eat.
    /// The responsibility of Food is to select a random position and points that it's worth.
    public class Score : Actor
    {
        private int points = 0;

        /// Constructs a new instance of an Food.
        public Score()
        {
            AddPoints(0);
        }

        /// Adds the given points to the score.
        /// <param name="points">The points to add.</param>
        public void AddPoints(int points)
        {
            this.points += points;
            SetText($"Score: {this.points}");
        }
    }
}