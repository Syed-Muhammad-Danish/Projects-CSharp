using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace TankBusters.GameGL
{
    internal class MakrovSmart:Makrov,iSmartEnemy
    {
        int speed;

        public MakrovSmart(Form form, int lives, CapPrice Captain, GameDirection direction, Image image, GameCell startCell) : base(form, lives, GameObjectType.ENEMY, image)
        {
            this.direction = direction;
            this.CurrentCell = startCell;
            this.Captain = Captain;
            this.speed = 1;
        }
        public int getSpeed()
        {
            return speed;
        }
        public override void flipEnemy()
        {
            if (flipPosition == "Left")
            {
                this.CurrentCell.PictureBox.Image = TankBusters.Properties.Resources.e3;
                faceDirection = GameDirection.Left;
            }
            else if (flipPosition == "Right")
            {
                this.CurrentCell.PictureBox.Image = TankBusters.Properties.Resources.e3_flip;
                faceDirection = GameDirection.Right;
            }
        }
        public override GameCell move()
        {
            if (getIsActive() == true)
            {
                speed++;
                if (speed % 3 == 0)
                {
                    manageDirections();
                    GameCell currentCell = this.CurrentCell;
                    GameObjectType nexttype = currentCell.nextCell(direction).CurrentGameObject.GameObjectType;
                    GameCell nextCell = currentCell.nextCell(direction);
                    if ((nextCell.CurrentGameObject.GameObjectType != GameObjectType.KEY))
                    {
                        this.CurrentCell = nextCell;
                    }
                    enemyDirection();
                    if (nextCell.CurrentGameObject.GameObjectType == GameObjectType.PLAYER)
                    {
                        
                        this.Captain.decreaseHealth (Game.enemyDamage);

                    }
                    if (currentCell != nextCell)
                    {
                        if ((nextCell.CurrentGameObject.GameObjectType != GameObjectType.KEY))
                        {
                            currentCell.setGameObject(Game.getBlankGameObject());
                        }

                    }
                    setFlipBool(true);
                    return nextCell;
                }

            }


            return null;
        }

        public void manageDirections()
        {
            double[] distance = new double[4] { 10000, 10000, 10000, 10000 };
            if (this.CurrentCell.nextCell(GameDirection.Left).CurrentGameObject.GameObjectType != GameObjectType.WALL)
            {
                distance[0] = calculateDistance(this.CurrentCell.nextCell(GameDirection.Left));

            }
            if (this.CurrentCell.nextCell(GameDirection.Right).CurrentGameObject.GameObjectType != GameObjectType.WALL)
            {
                distance[1] = calculateDistance(this.CurrentCell.nextCell(GameDirection.Right));


            }
            if (this.CurrentCell.nextCell(GameDirection.Up).CurrentGameObject.GameObjectType != GameObjectType.WALL)
            {
                distance[2] = calculateDistance(this.CurrentCell.nextCell(GameDirection.Up));
            }
            if (this.CurrentCell.nextCell(GameDirection.Down).CurrentGameObject.GameObjectType != GameObjectType.WALL)
            {
                distance[3] = calculateDistance(this.CurrentCell.nextCell(GameDirection.Down));
            }
            if (distance[0] <= distance[1] && distance[0] <= distance[2] && distance[0] <= distance[3])
            {

                this.direction = GameDirection.Left;
                flipPosition = "Left";
                faceDirection = GameDirection.Left;


            }
            if (distance[1] <= distance[0] && distance[1] <= distance[2] && distance[1] <= distance[3])
            {

                this.direction = GameDirection.Right;
                flipPosition = "Right";
                faceDirection = GameDirection.Right;

            }
            if (distance[2] <= distance[0] && distance[2] <= distance[1] && distance[2] <= distance[3])
            {
                this.direction = GameDirection.Up;

            }
            if (distance[3] <= distance[0] && distance[3] <= distance[1] && distance[3] <= distance[2])
            {
                this.direction = GameDirection.Down;

            }





        }




        public double calculateDistance(GameCell nextcell)
        {
            return Math.Sqrt(Math.Pow((Captain.CurrentCell.X - nextcell.X), 2) + Math.Pow((Captain.CurrentCell.Y - nextcell.Y), 2));
        }
    }
}
