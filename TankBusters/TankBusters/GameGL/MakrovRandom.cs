using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TankBusters.GameGL
{
    internal class MakrovRandom:Makrov
    {
        int randomDelay;
        int random;
        int moveDelay = 11;
        bool moveDelayChanger;



        public MakrovRandom(Form form,int lives, CapPrice Captain, GameDirection direction, Image image, GameCell startCell) : base(form, lives, GameObjectType.ENEMY, image)
        {
            this.direction = direction;
            this.CurrentCell = startCell;
            this.Captain = Captain;
        }

        public override GameCell move()
        {
            if (this.getIsActive() == true)
            {

                if (Captain.CurrentCell.X == this.CurrentCell.X && moveDelayChanger == true)
                {
                    moveDelay = 0;
                    moveDelayChanger = false;
                }
                if (moveDelay > 10)
                {
                    manageDirections();
                    GameCell currentCell = this.CurrentCell;
                    GameCell nextCell = currentCell.nextCell(direction);
                    GameObject previousObject = nextCell.CurrentGameObject;

                    if ((nextCell.CurrentGameObject.GameObjectType != GameObjectType.KEY))
                    {
                        this.CurrentCell = nextCell;
                    }



                    if (currentCell != nextCell)
                    {
                        if ((nextCell.CurrentGameObject.GameObjectType != GameObjectType.KEY))
                        {
                            currentCell.setGameObject(previousObject);
                        }


                    }
                    this.setFlipBool(true);

                    if (moveDelay > 30)
                    {
                        moveDelayChanger = true;
                    }

                }
                moveDelay++;
            }


            return null;
        }
        public void manageDirections()
        {
            if (randomDelay % 5 == 0)
            {
                Random r = new Random();
                random = r.Next(4);
            }
            base.enemyDirection();

            if (random == 0)
            {
                direction = GameDirection.Right;

            }
            else if (random == 1)
            {
                direction = GameDirection.Left;

            }
            else if (random == 2)
            {
                direction = GameDirection.Up;

            }
            else if (random == 3)
            {
                direction = GameDirection.Down;

            }
            randomDelay++;

        }
        public override void flipEnemy()
        {
            if (flipPosition == "Left")
            {
                this.CurrentCell.PictureBox.Image = TankBusters.Properties.Resources.e4_flip;
                faceDirection = GameDirection.Left;
            }
            else if (flipPosition == "Right")
            {
                this.CurrentCell.PictureBox.Image = TankBusters.Properties.Resources.e4;
                faceDirection = GameDirection.Right;
            }
        }
    }
}
