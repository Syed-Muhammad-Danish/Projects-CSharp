using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TankBusters.GameGL
{
    internal class MakrovVertical:Makrov
    {
        public MakrovVertical(Form form, int lives, CapPrice Captain, GameDirection direction, Image image, GameCell startCell) : base(form, lives, GameObjectType.ENEMY, image)
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
                    if ((nextCell.CurrentGameObject.GameObjectType != GameObjectType.WALL))
                    {
                        this.CurrentCell = nextCell;
                    }




                    if (currentCell == nextCell || (nextCell.CurrentGameObject.GameObjectType == GameObjectType.WALL))
                    {
                        manageDirections();

                    }

                    if (currentCell != nextCell)
                    {
                        if ((nextCell.CurrentGameObject.GameObjectType != GameObjectType.WALL))
                        {
                            currentCell.setGameObject(previousObject);
                        }

                        this.setFlipBool(true);

                    }





                }
                else if (Captain.CurrentCell.X == this.CurrentCell.X)
                {
                    base.enemyDirection();

                    // generateBullet();
                }
            }

            return null;

        }



        public void manageDirections()
        {
            if (direction == GameDirection.Down)
            {
                direction = GameDirection.Up;
                base.enemyDirection();

            }
            else if (direction == GameDirection.Up)
            {
                direction = GameDirection.Down;
                flipPosition = "Right";
                base.enemyDirection();

            }

        }

        public override void flipEnemy()
        {
            
        }
    }
}
