using TankBusters.GameGL;
using EZInput;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using System.IO;
using System.Threading;
namespace TankBusters
{
    public partial class Main : Form
    {
        int count = 0;
        public Main()
        {
            InitializeComponent();
        }

        private void BulletTimer_Tick(object sender, EventArgs e)
        {
            MakrovBulletsMovements();
            CaptainBulletsMovements();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            if (Keyboard.IsKeyPressed(Key.LeftArrow))
            {
                Game.cap.move(GameDirection.Left);
                if (Game.cap.getFlipPosition() == "Right")
                {
                    Game.cap.setFlipPosition("Left");

                }
                Game.cap.setFlip(true);
            }
            else if (Keyboard.IsKeyPressed(Key.RightArrow))
            {
                Game.cap.move(GameDirection.Right);
                if (Game.cap.getFlipPosition() == "Left")
                {
                    Game.cap.setFlipPosition("Right");

                }
                Game.cap.setFlip(true);
            }

            if (Game.cap.CurrentCell.nextWallCell(GameDirection.Down).CurrentGameObject.GameObjectType == GameObjectType.FAN)
            {

                Game.cap.setJumpHeight(2);

            }
            if (Keyboard.IsKeyPressed(Key.Space))
            {
                Game.cap.generateBullet();
            }



            if (Game.cap.getJumpHeight() > 0)
            {
                Game.cap.move(GameDirection.Up);
                Game.cap.setFlip(true);
                Game.cap.decreaseHieght();
            }
            else if (Game.cap.CurrentCell.nextWallCell(GameDirection.Down).CurrentGameObject.GameObjectType == GameObjectType.NONE)
            {
                Game.cap.move(GameDirection.Down);
                Game.cap.setFlip(true);
            }
            foreach (Makrov enemy in Game.enemies)
            {
                if (enemy.getIsActive() == true)
                {
                    enemy.move();


                    enemy.generateBullet();
                    if (enemy.getFlipBool() == true)
                    {
                        enemy.flipEnemy();
                        enemy.setFlipBool(false);
                    }


                    enemy.setBarPosition();
                    enemy.setBarValue();

                }

                if (enemy.getHealth() <= 0)
                {
                    enemy.setIsActive(false);

                    GameObject gameObj = Game.getBlankGameObject();
                    this.Controls.Remove(enemy.getBar());

                    enemy.CurrentCell.setGameObject(gameObj);

                }




            }
            for (int x = 0; x < Game.enemies.Count; x++)
            {
                if (Game.enemies[x].getIsActive() == false)
                {
                    Game.enemies.Remove(Game.enemies[x]);
                }
            }
            if (Game.cap.getHealth() == 0)
            {
                if (Game.lives > 0)
                {
                    Game.cap.setHealth(100);
                    Game.lives--;
                }
                else if (Game.lives == 0)
                {
                    GameTimer.Enabled = false;
                    MessageBox.Show("GameOver");
                    this.Dispose();
                    //MainMenu m = new MainMenu();

                }

            }
            if (Game.cap.getFlip() == true)
            {

                Game.cap.flipDeath();
                Game.cap.setFlip(false);

            }
            Game.cap.setBarPosition();
            Game.cap.setBarValue();

            label2.Text = "Score: " + Game.score;
            //lives.Text = "Lives: " + Game.lives;


            if (Game.enemies.Count == 0 && Game.palletcount == 0)
            {

                Game.levelClear = true;
                if (Game.levelClear == true)
                {
                    GameTimer.Enabled = false;
                    if (Game.level < 2)
                    {

                        Game.level++;
                        Game.levelClear = false;
                        this.Dispose();
                        Main g = new Main();
                        if (Game.level == 2)
                        {
                            Form3 f = new Form3();
                            f.Show();
                            f.BringToFront();
                            Thread.Sleep(15000);

                        }
                        g.Show();
                        //                     
                    }

                    else if (Game.level >= 2)
                    {
                        MessageBox.Show("GameComplete");
                        Ending end = new Ending();
                        end  .Show();
                        Game.levelClear = false;
                        this.Dispose();
                    }

                    //                 MessageBox.Show("WHTA");     
                }

                //   levelchanger();    


            }
        }

        void CaptainBulletsMovements()
        {
            foreach (Tanks b in Game.bullets)
            {
                b.move();
            }

            for (int x = 0; x < Game.bullets.Count; x++)
            {
                if (Game.bullets[x].getIsLive() == false)
                {
                    Game.bullets.RemoveAt(x);
                }
            }

        }
        void MakrovBulletsMovements()
        {
            foreach (Tanks b in Game.enemyBullets)
            {
                b.move();

            }
            for (int x = 0; x < Game.enemyBullets.Count; x++)
            {
                if (Game.enemyBullets[x].getIsLive() == false)
                {
                    Game.enemyBullets.RemoveAt(x);
                }
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            levelchanger();
        }
        void levelchanger()
        {

            if (Game.level == 0)
            {
                Game.enemyDamage = 3;
                Game.grid = new GameGrid("maze2.txt", 15, 27);

                Image Image = GameGL.Game.getGameObjectImage('P');
                GameCell startCell = Game.grid.getCell(12, 23);


                Game.cap = new CapPrice(this, 100, Image, startCell);



                Image Img = GameGL.Game.getGameObjectImage('h');
                GameCell h1 = Game.grid.getCell(1, 12);
                MakrovHorizontal enemy = new MakrovHorizontal(this, 100, Game.cap, GameDirection.Left, Img, h1);
                Game.enemies.Add(enemy);
                Image Img2 = GameGL.Game.getGameObjectImage('h');
                GameCell h2 = Game.grid.getCell(7, 12);
                MakrovHorizontal enemy3 = new MakrovHorizontal(this, 100, Game.cap, GameDirection.Right, Img2, h2);
                Game.enemies.Add(enemy3);
                Image Img1 = GameGL.Game.getGameObjectImage('v');
                GameCell v1 = Game.grid.getCell(4, 1);
                MakrovVertical enemy1 = new MakrovVertical(this, 100, Game.cap, GameDirection.Down, Img1, v1);
                Game.enemies.Add(enemy1);
                printMaze(Game.grid);
            }

            if (Game.level == 1)
            {
                Game.palletcount = 6;
                Game.enemyDamage = 5;
                Game.grid = new GameGrid("maze.txt", 15, 27);

                Image Image = GameGL.Game.getGameObjectImage('P');
                GameCell startCell = Game.grid.getCell(13, 23);


                Game.cap = new CapPrice(this, 100, Image, startCell);



                Image Img = GameGL.Game.getGameObjectImage('x');
                GameCell s1 = Game.grid.getCell(1, 12);
                MakrovSmart e = new MakrovSmart(this, 100, Game.cap, GameDirection.Left, Img, s1);
                Game.enemies.Add(e);
                Image Img2 = GameGL.Game.getGameObjectImage('r');
                GameCell h2 = Game.grid.getCell(7, 12);
                MakrovRandom e3 = new MakrovRandom(this, 100, Game.cap, GameDirection.Right, Img2, h2);
                Game.enemies.Add(e3);


                printMaze(Game.grid);
            }


            else if (Game.level == 2)
            {

                Game.enemyDamage = 5;
                Game.grid = new GameGrid("maze1.txt", 15, 27);

                Image Image = GameGL.Game.getGameObjectImage('P');
                GameCell startCell = Game.grid.getCell(12, 23);


                Game.cap = new CapPrice(this, 100, Image, startCell);



                Image Img = GameGL.Game.getGameObjectImage('h');
                GameCell h1 = Game.grid.getCell(1, 12);
                MakrovHorizontal enemy = new MakrovHorizontal(this, 100, Game.cap, GameDirection.Left, Img, h1);
                Game.enemies.Add(enemy);
                Image Img2 = GameGL.Game.getGameObjectImage('h');
                GameCell h2 = Game.grid.getCell(5, 16);
                MakrovHorizontal enemy3 = new MakrovHorizontal(this, 100, Game.cap, GameDirection.Right, Img2, h2);
                Game.enemies.Add(enemy3);
                Image Img1 = GameGL.Game.getGameObjectImage('v');
                GameCell v1 = Game.grid.getCell(4, 1);
                MakrovVertical enemy1 = new MakrovVertical(this, 100, Game.cap, GameDirection.Down, Img1, v1);
                Game.enemies.Add(enemy1);
                Image Img3 = GameGL.Game.getGameObjectImage('v');
                GameCell v2 = Game.grid.getCell(2, 24);
                MakrovVertical enemy2 = new MakrovVertical(this, 100, Game.cap, GameDirection.Down, Img3, v2);
                Game.enemies.Add(enemy2);

                Image Img4 = GameGL.Game.getGameObjectImage('x');
                GameCell s1 = Game.grid.getCell(12, 12);
                MakrovSmart enemy4 = new MakrovSmart(this, 100, Game.cap, GameDirection.Left, Img4, s1);
                Game.enemies.Add(enemy4);
                Image Img5 = GameGL.Game.getGameObjectImage('r');
                GameCell r = Game.grid.getCell(7, 19);
                MakrovRandom enemy5 = new MakrovRandom(this, 100, Game.cap, GameDirection.Right, Img5, r);
                Game.enemies.Add(enemy5);
                Image Img6 = GameGL.Game.getGameObjectImage('r');
                GameCell r1 = Game.grid.getCell(11, 4);
                MakrovRandom enemy6 = new MakrovRandom(this, 100, Game.cap, GameDirection.Right, Img6, r1);
                Game.enemies.Add(enemy6);


                printMaze(Game.grid);

            }


        }
        void printMaze(GameGrid grid)
        {
            for (int x = 0; x < grid.Rows; x++)
            {
                for (int y = 0; y < grid.Cols; y++)
                {
                    GameCell cell = grid.getCell(x, y);
                    this.Controls.Add(cell.PictureBox);
                }
            }
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}