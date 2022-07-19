//greed
//Jaelee Hutchinson

using System;


namespace greed.Casting
{
    /// A thing that participates in the game
    /// The responsibility of Actor is to keep track of its appearance, position and velocity in 2d 
    /// space.
    public class Actor
    {
        private string text = "";
        private int fontSize = 15;
        private Color color = new Color(255, 255, 255); // white
        private Point position = new Point(0, 0);
        private Point velocity = new Point(0, 0);

        /// Constructs a new instance of Actor.
        public Actor()
        {
        }

        /// Gets the actor's color.
        /// <returns>The color.</returns>
        public Color GetColor()
        {
            return color;
        }

        /// Gets the actor's font size.
        /// <returns>The font size.</returns>
        public int GetFontSize()
        {
            return fontSize;
        }

        /// Gets the actor's position.
        /// <returns>The position.</returns>
        public Point GetPosition()
        {
            return position;
        }

        /// Gets the actor's text.
        /// <returns>The text.</returns>
        public string GetText()
        {
            return text;
        }

        /// Gets the actor's current velocity.
        /// <returns>The velocity.</returns>
        public Point GetVelocity()
        {
            return velocity;
        }

        /// Moves the actor to its next position according to its velocity. Will wrap the position 
        /// from one side of the screen to the other when it reaches the maximum x and y 
        /// values.
        /// <param name="maxX">The maximum x value.</param>
        /// <param name="maxY">The maximum y value.</param>
        public void MoveNext(int maxX, int maxY)
        {
            int x = ((position.GetX() + velocity.GetX()) + maxX) % maxX;
            int y = ((position.GetY() + velocity.GetY()) + maxY) % maxY;
            position = new Point(x, y);

        }

        /// Sets the actor's color to the given value.
        /// <param name="color">The given color.</param>
        /// <exception cref="ArgumentException">When color is null.</exception>
        public void SetColor(Color color)
        {
            if (color == null)
            {
                throw new ArgumentException("color can't be null");
            }
            this.color = color;
        }

        /// Sets the actor's font size to the given value.
        /// <param name="fontSize">The given font size.</param>
        /// <exception cref="ArgumentException">
        /// When font size is less than or equal to zero.
        /// </exception>
        public void SetFontSize(int fontSize)
        {
            if (fontSize <= 0)
            {
                throw new ArgumentException("fontSize must be greater than zero");
            }
            this.fontSize = fontSize;
        }

        /// Sets the actor's position to the given value.
        /// <param name="position">The given position.</param>
        /// <exception cref="ArgumentException">When position is null.</exception>
        public void SetPosition(Point position)
        {
            if (position == null)
            {
                throw new ArgumentException("position can't be null");
            }
            this.position = position;
        }

        /// Sets the actor's text to the given value.
        /// <param name="text">The given text.</param>
        /// <exception cref="ArgumentException">When text is null.</exception>
        public void SetText(string text)
        {
            if (text == null)
            {
                throw new ArgumentException("text can't be null");
            }
            this.text = text;
        }

        /// Sets the actor's velocity to the given value.
        /// <param name="velocity">The given velocity.</param>
        /// <exception cref="ArgumentException">When velocity is null.</exception>
        public void SetVelocity(Point velocity)
        {
            if (velocity == null)
            {
                throw new ArgumentException("velocity can't be null");
            }
            this.velocity = velocity;
        }

    }
}