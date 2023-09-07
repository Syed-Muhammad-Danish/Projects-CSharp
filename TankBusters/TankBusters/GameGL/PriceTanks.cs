using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TankBusters.GameGL
{
    internal class PriceTanks:Tanks
    {
        private List<Makrov> enemies;

        public PriceTanks()
        {

        }
        public PriceTanks(List<Makrov> enemies, GameDirection direction, Image image, GameCell startCell) : base(GameObjectType.PLAYERBULLET, image)
        {
            this.direction = direction;
            this.CurrentCell = startCell;
            this.enemies = enemies;

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
                    if ((nextCell.CurrentGameObject.GameObjectType != GameObjectType.REWARD))
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
                    if (nextObject.GameObjectType == GameObjectType.ENEMY)
                    {
                        Game.increaseScore(1);
                        foreach (Makrov enemy in enemies)
                        {
                            GameCell next = enemy.CurrentCell.nextWallCell(GameDirection.Left);
                            GameObject obj = next.CurrentGameObject;
                            GameCell next2 = enemy.CurrentCell.nextWallCell(GameDirection.Right);
                            GameObject obj2 = next2.CurrentGameObject;

                            if (obj.GameObjectType == GameObjectType.PLAYERBULLET)
                            {
                                enemy.decreaseHealth(Game.playerDamage);
                            }
                            if (obj2.GameObjectType == GameObjectType.PLAYERBULLET)
                            {
                                enemy.decreaseHealth(Game.playerDamage);
                            }


                        }

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
