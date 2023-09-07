using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TankBusters.GameGL
{
    internal class MakrovTanks : Tanks
    {
        CapPrice captian;

        public MakrovTanks(CapPrice captian, GameDirection direction, Image image, GameCell startCell) : base(GameObjectType.BULLET, image)
        {
            this.direction = direction;
            this.CurrentCell = startCell;
            this.captian = captian;

        }
        public MakrovTanks()
        {

        }

        public override GameCell move()
        {
            if (getIsLive() == true)
            {
                GameCell currentCell = this.CurrentCell;
                GameCell nextCell = currentCell.nextCell(direction);
                GameCell nextCell2 = currentCell.nextWallCell(direction);

                if (nextCell.CurrentGameObject.GameObjectType != GameObjectType.REWARD)
                {
                    this.CurrentCell = nextCell;
                }

                GameObject previousObject = nextCell.CurrentGameObject;
                GameObject nextObject = nextCell2.CurrentGameObject;


                if (currentCell != nextCell)
                {
                    if (nextCell.CurrentGameObject.GameObjectType != GameObjectType.REWARD)
                    {
                        currentCell.setGameObject(Game.getBlankGameObject());
                    }
                    else
                    {
                        CurrentCell.setGameObject(Game.getBlankGameObject());
                        this.isActive = false;


                    }
                }
                if (currentCell == nextCell || nextCell.CurrentGameObject.GameObjectType == GameObjectType.KEY)
                {
                    if (nextObject.GameObjectType == GameObjectType.PLAYER)
                    {
                        captian.decreaseHealth(Game.enemyDamage);

                    }

                    currentCell.setGameObject(Game.getBlankGameObject());

                    this.setIsLive(false);

                }
                return nextCell;
            }

            return null;
        }
    }
}
