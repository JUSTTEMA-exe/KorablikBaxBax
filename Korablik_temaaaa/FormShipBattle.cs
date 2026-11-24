using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Korablik_temaaaa
{
    public partial class FormShipBattle : Form
    {
        private int shipSpeed = 5;
        private int ballSpeed = 12;
        private Timer gameTimer;

        public FormShipBattle()
        {
            InitializeComponent();

            this.DoubleBuffered = true;

            if (pictureBoxCanon.Image != null)
            {
                pictureBoxCanon.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }

            gameTimer = new Timer();
            gameTimer.Interval = 16;
            gameTimer.Tick += GameTimer_Tick;
            this.KeyDown += FormShipBattle_KeyDown;
            StartNewGame();
        }

        private void StartNewGame()
        {
            pictureBoxShip.Visible = true;
            pictureBoxShip.Left = (this.ClientSize.Width - pictureBoxShip.Width) / 2;
            pictureBoxShip.Top = 25;
            pictureBoxCanon.Left = (this.ClientSize.Width - pictureBoxCanon.Width) / 2;
            pictureBoxCanon.Top = this.ClientSize.Height - pictureBoxCanon.Height - 10;
            pictureBoxBall.Visible = false;
            pictureBoxBoom.Visible = false;
            if (shipSpeed < 0)
            {
                shipSpeed = -shipSpeed;
                FlipShip();
            }
            gameTimer.Start();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            MoveShip();
            if (pictureBoxBall.Visible)
            {
                MoveBall();
            }
        }

        private void MoveShip()
        {
            pictureBoxShip.Left += shipSpeed;
            if (pictureBoxShip.Right >= this.ClientSize.Width || pictureBoxShip.Left <= 0)
            {
                shipSpeed = -shipSpeed;
                FlipShip();
            }
        }


        private void MoveBall()
        {
            pictureBoxBall.Top -= ballSpeed;
            if (pictureBoxBall.Bounds.IntersectsWith(pictureBoxShip.Bounds))
            {
                ShowBoom();
                MessageBox.Show("Да ты снайпер!", "Победа!");
                StartNewGame();
            }
            else if (pictureBoxBall.Bottom < 0)
            {
                pictureBoxBall.Visible = false;
            }
        }

        private void ShowBoom()
        {
            gameTimer.Stop();

            pictureBoxBoom.Left = pictureBoxShip.Left + (pictureBoxShip.Width - pictureBoxBoom.Width) / 2;
            pictureBoxBoom.Top = pictureBoxShip.Top + (pictureBoxShip.Height - pictureBoxBoom.Height) / 2;

            pictureBoxBall.Visible = false;
            pictureBoxShip.Visible = false;
            pictureBoxBoom.Visible = true;

            this.Refresh();
        }

        private void FormShipBattle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && !pictureBoxBall.Visible)
            {
                pictureBoxBall.Left = pictureBoxCanon.Left + (pictureBoxCanon.Width - pictureBoxBall.Width) / 2;
                pictureBoxBall.Top = pictureBoxCanon.Top - pictureBoxBall.Height;
                pictureBoxBall.Visible = true;
            }
        }
        private void FlipShip()
        {
            if (pictureBoxShip.Image != null)
            {
                pictureBoxShip.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                pictureBoxShip.Refresh();
            }
        }
    }
}