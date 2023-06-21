using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pong
{
    internal class npcPaddle
    {
        private const int SIZE = 50;
        private Random random;
        private Point position;
        private Point speed;
        private Color colour;
        private Graphics graphics;
        private Size clientSize;

        public npcPaddle(Random random, Point position, Point speed, Color colour, Graphics graphics, Size clientSize)
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
        public void npcMove()
        {
            //position.Y += speed.Y;
            position.Y += random.Next(-10, 11);
            speed.Y = 50;
        }
        public void npcMove2()
        {
            //position.Y -= speed.Y;
            position.Y += random.Next(-10, 11);
            speed.Y = 50;
        }
    }
}
