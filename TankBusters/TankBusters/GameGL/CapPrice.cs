using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TankBusters.GameGL
{
    internal class CapPrice:GameObject
    {
        bool isActive;

        private int health;
        private string flipPosition = "Right";
        private bool flipBool = false;
        private int jumpHeight = 0;
        ProgressBar Caphealth;
        Main form;
        int level;

        public CapPrice(Main form, int health, Image image, GameCell startCell) : base(GameObjectType.PLAYER, image)
        {
            this.health = health;

            this.CurrentCell = startCell;
            this.form = form;
            Caphealth = new ProgressBar();

            Caphealth = new ProgressBar();
            Caphealth.Size = new Size(30, 7);
            Caphealth.ForeColor = Color.Green;
            Caphealth.BackColor = Color.Black;
            Caphealth.Style = ProgressBarStyle.Continuous;
            form.Controls.Add(Caphealth);




        }

        public int Health { get => health; set => health = value; }




        public int getHealth()
        {
            return health;
        }
        public void setHealth(int health)
        {
            this.health = health;
        }
        public void setIsActive(bool set)
        {
            this.isActive = set;
        }
        public bool getIsActive()
        {
            return isActive;
        }

        public void increasHealth()
        {
            health = health + 5;
        }

        public void decreaseHealth(int damage)
        {
            health = health - damage;
        }

        public GameCell move(GameDirection direction)
        {
            GameCell currentCell = this.CurrentCell;
            GameCell nextCell = currentCell.nextCell(direction);
            addScores(nextCell);
            if (nextCell.CurrentGameObject.GameObjectType == GameObjectType.KEY)
            {
                Game.levelClear = true;
                Game.increaseScore(10);
            }


            this.CurrentCell = nextCell;




            if (currentCell != nextCell)
            {

                currentCell.setGameObject(Game.getBlankGameObject());

            }
            return nextCell;
        }

        private void addScores(GameCell nextCell)
        {
            if (nextCell.CurrentGameObject.GameObjectType == GameObjectType.REWARD)
            {
                Game.score = Game.score + 5;
                Game.palletcount--;
            }

        }
        public int getJumpHeight()
        {
            return jumpHeight;
        }

        public void setJumpHeight(int height)
        {
            this.jumpHeight = height;
        }

        public void decreaseHieght()
        {
            jumpHeight--;
        }

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

        public void flipDeath()
        {
            if (flipPosition == "Left")
            {
                this.CurrentCell.PictureBox.Image = TankBusters.Properties.Resources.p1;
            }
            if (flipPosition == "Right")
            {
                this.CurrentCell.PictureBox.Image = TankBusters.Properties.Resources.p1_flip;
            }
        }


        public ProgressBar getBar()
        {
            return Caphealth;
        }

        public void setBarValue()
        {
            if (health >= 0)
            {
                Caphealth.Value = health;
            }

        }

        public void setBarPosition()
        {
            Caphealth.Top = this.CurrentCell.X * 46;
            Caphealth.Left = this.CurrentCell.Y * 50;
        }

        

        

        public bool getFlip()
        {
            return flipBool;
        }

        public void setFlip(bool flip)
        {
            flipBool = flip;
        }

        


        public void generateBullet()
        {
            PriceTanks b = new PriceTanks();
            Image bullet = GameGL.Game.getGameObjectImage('Q');
            GameCell startBullet = new GameCell();
            if (this.getFlipPosition() == "Right")
            {
                GameCell next = this.CurrentCell.nextWallCell(GameDirection.Right);
                if (next.CurrentGameObject.GameObjectType == GameObjectType.NONE)
                {
                    startBullet = this.CurrentCell.nextCell(GameDirection.Right);
                    b = new PriceTanks(Game.enemies, GameDirection.Right, bullet, startBullet);
                    b.setIsLive(true);
                    Game.bullets.Add(b);
                }

            }
            else if (this.getFlipPosition() == "Left")
            {
                GameCell next = this.CurrentCell.nextWallCell(GameDirection.Left);
                if (next.CurrentGameObject.GameObjectType == GameObjectType.NONE)
                {
                    startBullet = this.CurrentCell.nextCell(GameDirection.Left);
                    b = new PriceTanks(Game.enemies, GameDirection.Left, bullet, startBullet);
                    b.setIsLive(true);
                    Game.bullets.Add(b);
                }
            }
        }

    }
}
