using System;

namespace pong
{
    public partial class Form1 : Form
    {
        private const int TOTAL = 1;
        private const int RED_POSITION = 180;

        private Graphics graphics;
        private Random random;
        private Ball ball;
        private playerPaddle paddleLeft;
        private npcPaddle npcpaddle;
        public Form1()
        {
            InitializeComponent();
            graphics = CreateGraphics();
            random = new Random();

            ball = new Ball(random, new Point(RED_POSITION, RED_POSITION), new Point(10, 10), Color.Black, graphics, ClientSize);
            paddleLeft = new playerPaddle(random, new Point(10, 10), new Point(10, 10), Color.DeepSkyBlue, graphics, ClientSize);
            npcpaddle = new npcPaddle(random, new Point(100, 100), new Point(10, 10), Color.Red, graphics, ClientSize);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();            
            ball.Draw();
            ball.Move();
            ball.BounceSide();
            paddleLeft.draw();
            npcpaddle.draw();
            npcpaddle.npcMove();
            npcpaddle.npcMove2();
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Up) paddleLeft.Move2();
            else if (e.KeyCode == Keys.Down) paddleLeft.Move();
        }
    }
}