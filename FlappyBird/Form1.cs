using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class Form1 : Form
    {
        int gravity = 10;
        int pipeSpeed = 6;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }


        private void timer1_Tick_1(object sender, EventArgs e)
        {
            bird.Top += gravity;
            scoreLabel.Text = $"Score: {score}";
            
            PipeTop1.Left -= pipeSpeed;
            PipeBot1.Left -= pipeSpeed;
            PipeTop2.Left -= pipeSpeed;
            PipeBot2.Left -= pipeSpeed;
            PipeTop3.Left -= pipeSpeed;
            PipeBot3.Left -= pipeSpeed;

            if (PipeTop1.Left < -60 )
            {
                PipeTop1.Left = 660;
                score++;
            }
            

            if (PipeBot1.Left < -60)
            {
                PipeBot1.Left = 700;
                score++;
            }

            if (PipeTop2.Left < -60)
            {
                PipeTop2.Left = 660;
                score++;
            }


            if (PipeBot2.Left < -60)
            {
                PipeBot2.Left = 700;
                score++;
            }

            if (PipeTop3.Left < -60)
            {
                PipeTop3.Left = 660;
                score++;
            }


            if (PipeBot3.Left < -60)
            {
                PipeBot3.Left = 700;
                score++;
            }

            //siin ma lihtsalt unustasin kuidas võiks kokku panna neid

            if (bird.Top < -25)
            {
                gameOver();
            }

            if (bird.Bounds.IntersectsWith(PipeTop1.Bounds) || bird.Bounds.IntersectsWith(PipeBot1.Bounds)
                || bird.Bounds.IntersectsWith(PipeTop2.Bounds) || bird.Bounds.IntersectsWith(PipeBot2.Bounds))
            {
                    gameOver();
            }

            if(bird.Bounds.IntersectsWith(PipeTop3.Bounds) || bird.Bounds.IntersectsWith(PipeBot3.Bounds))
            {
                gameOver();
            }
            if (bird.Bounds.IntersectsWith(ground.Bounds))
            {
                gameOver();
            }

            //ilmnes probleem kus see ei lubanud mul asetada kõik intersect-id ühte if funktsiooni
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = -5;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = 5;
            }
        }

        private void gameOver()
        {
            timer1.Stop();
            scoreLabel.Text = $"Game Over!";
            replay.Visible = true;
        }

        private void replay_Click(object sender, EventArgs e)
        {
            Form1 NewForm = new Form1();
            NewForm.Show();
            this.Dispose(false);
        }
    }
}
