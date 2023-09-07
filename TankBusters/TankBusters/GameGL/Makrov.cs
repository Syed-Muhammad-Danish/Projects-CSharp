using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TankBusters.GameGL
{
    internal abstract class Makrov:GameObject
    {
        protected ProgressBar enemyBar = new ProgressBar();
        protected int health;
        protected CapPrice Captain;
        protected string flipPosition = "Right";
        protected bool flipBool = false;
        Form form;
        bool isActive;

        protected GameDirection direction;
        protected GameDirection faceDirection;
        protected int bulletDelay = 1;
        public Makrov(Form form, int health, GameObjectType gameObjectType, Image image) : base(GameObjectType.ENEMY, image)
        {
            this.health = health;
            this.form = form;


            enemyBar = new ProgressBar();
            enemyBar.Size = new Size(30, 7);
            enemyBar.ForeColor = Color.Red;
            enemyBar.BackColor = Color.Black;
            enemyBar.Style = ProgressBarStyle.Continuous;
            isActive = true;

            form.Controls.Add(enemyBar);

        }
        public abstract GameCell move();
        public string getFlipPosition()
        {
            return flipPosition;
        }

        public void setFlipPosition(string position)
        {
            flipPosition = position;
        }

        public bool getFlipBool()
        {
            return flipBool;
        }

        public void setFlipBool(bool flip)
        {
            flipBool = flip;
        }



        public void setIsActive(bool set)
        {
            this.isActive = set;
        }
        public bool getIsActive()
        {
            return isActive;
        }



        public int getHealth()
        {
            return health;
        }

        public void increasHealth()
        {
            health = health + 5;
        }

        public void decreaseHealth(int damage)
        {
            health = health - damage;

        }

        public ProgressBar getBar()
        {
            return enemyBar;
        }

        public void setBarValue()
        {
            if (health >= 0)
            {
                enemyBar.Value = health;
            }

        }

        public void setBarPosition()
        {
            enemyBar.Top = this.CurrentCell.X * 46;
            enemyBar.Left = this.CurrentCell.Y * 50;
        }

        void generateNormalBullet()
        {

            if (Captain.CurrentCell.X == this.CurrentCell.X)
            {
                if (bulletDelay == 2)
                {
                    this.setFlipBool(true);
                }

                if (bulletDelay % 3 == 0)
                {
                    this.setFlipBool(false);

                    MakrovTanks b = new MakrovTanks();
                    Image bullet = TankBusters.Properties.Resources.fire_pic;
                    GameCell startBullet = new GameCell();

                    startBullet = this.CurrentCell.nextCell(faceDirection);
                    b = new MakrovTanks(Captain, faceDirection, bullet, startBullet);

                    b.setIsLive(true);
                    Game.enemyBullets.Add(b);
                }
                bulletDelay++;
            }
            else
            {
                bulletDelay = 1;
            }




        }


        public void generateBullet()
        {
            GameCell currentCell = this.CurrentCell;
            GameCell nextCell = currentCell.nextWallCell(faceDirection);


            if (nextCell.CurrentGameObject.GameObjectType == GameObjectType.NONE)
            {

                    generateNormalBullet();
               
            }


        }
        public abstract void flipEnemy();
        

        protected void enemyDirection()
        {
            if (Captain.CurrentCell.Y < this.CurrentCell.Y)
            {
                flipPosition = "Left";
                faceDirection = GameDirection.Left;
            }
            else if (Captain.CurrentCell.Y > this.CurrentCell.Y)
            {
                flipPosition = "Right";
                faceDirection = GameDirection.Right;
            }

        }
    }
    interface iSmartEnemy
    {
        double calculateDistance(GameCell nextcell);
    }
}
