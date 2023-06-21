using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pong
{
    internal class Ball
    {
        private const int SIZE = 15;
        private Random random;
        private Point position;
        private Point speed;
        private Color colour;
        private Graphics graphics;
        private Size clientSize;

        public Ball(Random random, Point position, Point speed, Color colour, Graphics graphics, Size clientSize)
        {
            this.random = random;
            this.position = position;
            this.speed = speed;
            this.colour = colour;
            this.graphics = graphics;
            this.clientSize = clientSize;
        }

        public void Draw()
        {
            graphics.FillEllipse(new SolidBrush(colour), new Rectangle(position.X, position.Y, SIZE, SIZE));
        }

        public void Move()
        {
            position.X += speed.X;
            position.Y += speed.Y;
        }

        public void BounceSide()
        {
            if (position.X <= 0 || position.X + SIZE >= clientSize.Width)
            {
                speed.X = -speed.X;
            }
            if (position.Y <= 0 || position.Y + SIZE >= clientSize.Height)
            {
                speed.Y = -speed.Y;
            }
        }
    }
}