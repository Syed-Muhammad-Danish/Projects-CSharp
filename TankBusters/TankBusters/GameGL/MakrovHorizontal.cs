using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TankBusters.GameGL
{
    internal class MakrovHorizontal:Makrov
    {
        public MakrovHorizontal(Main form, int lives, CapPrice Captain, GameDirection direction, Image image, GameCell startCell) : base(form, lives, GameObjectType.ENEMY, image)
        {
            this.direction = direction;
            this.CurrentCell = startCell;
            this.Captain = Captain;
        }

        public override GameCell move()
        {
            if (this.getIsActive() == true)
            {
                if (Captain.CurrentCell.X != this.CurrentCell.X)
                {
                    GameCell currentCell = this.CurrentCell;
                    GameCell nextCell = currentCell.nextCell(direction);
                    GameCell nextCell2 = currentCell.nextWallCell(direction);
                    GameObject previousObject = nextCell.CurrentGameObject;
                    if ((nextCell.CurrentGameObject.GameObjectType != GameObjectType.KEY))
                    {
                        this.CurrentCell = nextCell;
                    }

                    GameCell downCell = nextCell.nextWallCell(GameDirection.Down);


                    if (currentCell == nextCell || (nextCell.CurrentGameObject.GameObjectType == GameObjectType.KEY))
                    {
                        manageDirections();

                    }

                    if (currentCell != nextCell)
                    {
                        if ((nextCell.CurrentGameObject.GameObjectType != GameObjectType.KEY))
                        {
                            currentCell.setGameObject(previousObject);
                        }

                        if (downCell.CurrentGameObject.GameObjectType == GameObjectType.V_WALL)
                        {
                            manageDirections();
                        }
                        this.setFlipBool(true);

                    }




                }
                else if (Captain.CurrentCell.X == this.CurrentCell.X)
                {
                    base.enemyDirection();


                }
            }

            return null;

        }



        public void manageDirections()
        {
            if (direction == GameDirection.Left)
            {
                direction = GameDirection.Right;
                flipPosition = "Right";
            }
            else if (direction == GameDirection.Right)
            {
                direction = GameDirection.Left;
                flipPosition = "Left";
            }
        }
        public override void flipEnemy()
        {
            if (flipPosition == "Left")
            {
                this.CurrentCell.PictureBox.Image = TankBusters.Properties.Resources.e1;
                faceDirection = GameDirection.Left;
            }
            else if (flipPosition == "Right")
            {
                this.CurrentCell.PictureBox.Image = TankBusters.Properties.Resources.e1_flip;
                faceDirection = GameDirection.Right;
            }
        }

    }
}
