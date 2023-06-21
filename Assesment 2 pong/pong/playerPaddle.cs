using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pong
{
    internal class playerPaddle
    {
        private const int SIZE = 50;
        private const int Width = 10;
        private Random random;
        private Point position;
        private Point speed;
        private Color colour;
        private Graphics graphics;
        private Size clientSize;


        public playerPaddle(Random random, Point position, Point speed, Color colour, Graphics graphics, Size clientSize)
        {
            this.random = random;
            this.position = position;
            this.speed = speed;
            this.colour = colour;
            this.graphics = graphics;
            this.clientSize = clientSize;
        }
        public void draw()
        {
            graphics.FillRectangle(new SolidBrush(colour), new Rectangle(position.X, position.Y, SIZE, SIZE));
        }
        public void Move()
        {
            position.Y += 10;
            side();

        }
        public void Move2()
        {
            position.Y -= 10;
            side();
        }
        public void side()
        {
            if (position.Y < 0)
            {
                position.Y = 0;
            }
            if (position.Y + 50 > clientSize.Height)
            {
                position.Y = clientSize.Height - 50;
            }
        }
    }
}

