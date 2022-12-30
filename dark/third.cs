using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EZInput;

namespace dark
{
    public partial class third : Form
    {
        PictureBox plyman;
        PictureBox enemyman;
        PictureBox gate;
        PictureBox fire;
        PictureBox bomb;
        string enemydirection;
        ProgressBar playerhealth;
        List<PictureBox> playerfire = new List<PictureBox>();
        List<PictureBox> playerbomb = new List<PictureBox>();
        public third()
        {
            InitializeComponent();
        }

        private void Third_Load(object sender, EventArgs e)
        {
            addplayer();
            addenemy();
            addgate();
            createfire();
            createbombs();
        }
        private void createbombs()
        {
            int x = 70;
            int count = 1;
            for (int i = 1; i <= 4; i++)
            {
                bomb = new PictureBox();
                bomb.Name = "bomb" + count;
                Image img = dark.Properties.Resources.bom__1_;
                bomb.Image = img;
                bomb.BackColor = Color.Transparent;
                bomb.Location = new System.Drawing.Point(x, 5);
                bomb.Width = img.Width;
                bomb.Height = img.Height;
                playerbomb.Add(bomb);
                this.Controls.Add(bomb);
                x = x + 300;
                count++;
            }

        }

        private void createfire()
        {
            int x = 30;
            int firecount = 1;
            for (int i = 1; i <= 13; i++)
            {
                fire = new PictureBox();
                fire.Name = "fire" + firecount;
                Image img = dark.Properties.Resources.Bullet__1___1_;
                fire.Image = img;
                fire.BackColor = Color.Transparent;
                fire.Location = new System.Drawing.Point(x, 3);
                fire.Width = img.Width;
                fire.Height = img.Height;
                playerfire.Add(fire);
                this.Controls.Add(fire);
                x = x + 100;
                firecount++;
            }
        }

        private void addgate()
        {
            gate = new PictureBox();
            Image img = dark.Properties.Resources.gateuse;
            gate.Image = img;
            gate.BackColor = Color.Transparent;
            gate.Location = new System.Drawing.Point(1105, 520);
            gate.Width = img.Width;
            gate.Height = img.Height;
            this.Controls.Add(gate);
        }

        private void addenemy()
        {
            enemyman = new PictureBox();
            Image img = dark.Properties.Resources.danger;
            enemyman.Image = img;
            enemyman.BackColor = Color.Transparent;
            enemyman.Location = new System.Drawing.Point(1170, 600);
            enemyman.Width = img.Width;
            enemyman.Height = img.Height;
            this.Controls.Add(enemyman);
            enemydirection = "left";
        }

        private void addplayer()
        {
            plyman = new PictureBox();
            Image img = dark.Properties.Resources.Jump__9___1_;
            plyman.Image = img;
            plyman.BackColor = Color.Transparent;
            plyman.Location = new System.Drawing.Point(5, 660);
            plyman.Width = img.Width;
            plyman.Height = img.Height;
            this.Controls.Add(plyman);

            playerhealth = new ProgressBar();
            playerhealth.Value = 100;
            playerhealth.Location = new System.Drawing.Point(1260, 60);
            this.Controls.Add(playerhealth);
        }
        private void fireplay()
        {
            int count = 1;
            foreach (Control c in Controls)
            {
                if (c.Name == "fire" + count)
                {
                    c.Top = c.Top + 7;
                    count++;
                }

            }

        }
        private void moveenemy()
        {
            if (enemydirection == "left")
            {
                enemyman.Left = enemyman.Left - 5;
            }
            if (enemyman.Left <= 0)
            {
                enemyman.Location = new System.Drawing.Point(1170, 600);
                enemyman.Left = enemyman.Left - 5;

            }
        }

        private void moveplayer()
        {
            if (Keyboard.IsKeyPressed(Key.RightArrow))
            {
                plyman.Image = Properties.Resources.Jump__9___1_;
                plyman.Left = plyman.Left + 15;
            }
            if (Keyboard.IsKeyPressed(Key.LeftArrow))
            {
                if (plyman.Left <= 0)
                {
                    plyman.Location = new System.Drawing.Point(5, 660);

                }
                plyman.Image = Properties.Resources.runleft;
                plyman.Left -= 15;
            }

        }

        private void jump()
        {
            plyman.Top -= 250;
            plyman.Image = Properties.Resources.Jump__9___1_;
            plyman.Left += 100;
            plyman.Image = Properties.Resources.Jump__9___1_;
            plyman.Top += 250;
            plyman.Image = Properties.Resources.Jump__9___1_;

        }
        private void gamelose()
        {
            if (playerhealth.Value == 0)
            {
                fireloop.Enabled = false;
                this.Hide();
                loss l = new loss();
                l.ShowDialog();
            }
        }

        private void nextform()
        {
            if (plyman.Bounds.IntersectsWith(gate.Bounds))
            {
                fireloop.Enabled = false;
                plyman.Visible = false;
                this.Hide();
                winformcs s = new winformcs();
                s.ShowDialog();
            }

        }

        private void playerlife()
        {
            if (plyman.Left+20==enemyman.Left)
            {
                if (playerhealth.Value > 0)
                {
                    playerhealth.Value=0;

                }

            }

        }

        private void resetcoordinates()
        {
            int firecount = 1;
            int x = 30;
            for (int i = 0; i < Controls.Count; i++)
            {
                if (Controls[i].Name == "fire" + firecount)
                {
                    if (Controls[i].Top >= 720)
                    {
                        Controls[i].Location = new System.Drawing.Point(x, 3);
                    }
                    firecount++;
                    x = x + 100;
                }
            }
        }
        private void resetbombcoordinates()
        {
            int count = 1;
            int x = 70;
            for (int i = 0; i < Controls.Count; i++)
            {
                if (Controls[i].Name == "bomb" + count)
                {
                    if (Controls[i].Top >= 720)
                    {
                        Controls[i].Location = new System.Drawing.Point(x, 3);
                    }
                    count++;
                    x = x + 300;
                }
            }
        }

        private void bombplay()
        {
            int count = 1;
            foreach (Control c in Controls)
            {
                if (c.Name == "bomb" + count)
                {
                    c.Top = c.Top + 12;
                    count++;
                }

            }
        }
       
        private void Gameloop_Tick_1(object sender, EventArgs e)
        {
            moveplayer();
            moveenemy();
        }

        private void Fireloop_Tick(object sender, EventArgs e)
        {
            fireplay();
            resetcoordinates();
            playerlife();
            nextform();
            gamelose();
            bombplay();
            resetbombcoordinates();
        }

        private void Jumping_Tick(object sender, EventArgs e)
        {
            if (Keyboard.IsKeyPressed(Key.UpArrow))
            {
                jump();
            }
        }

        private void Collide_Tick(object sender, EventArgs e)
        {
            foreach (PictureBox fire in playerfire)
            {
                if (fire.Bounds.IntersectsWith(plyman.Bounds))
                {
                    if (playerhealth.Value > 0)
                    {
                        playerhealth.Value = playerhealth.Value - 10;

                    }

                }
            }
            foreach (PictureBox bomb in playerbomb)
            {
                if (bomb.Bounds.IntersectsWith(plyman.Bounds))
                {
                    if (playerhealth.Value > 0)
                    {
                        playerhealth.Value = 0;
                        fireloop.Enabled = false;
                        this.Hide();
                        loss l = new loss();
                        l.ShowDialog();
                    }

                }
            }
        }
    }
}
