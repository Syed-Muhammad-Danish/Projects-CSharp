using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TankBusters.GameGL
{
    internal abstract class Tanks : GameObject
    {

        protected bool isActive = false;
        protected GameDirection direction;

        public Tanks(GameObjectType gameObjectType, Image image) : base(gameObjectType, image)
        {

        }

        public GameDirection getDirection()
        {
            return direction;
        }

        public Tanks()
        {

        }

        public abstract GameCell move();

        public void setIsLive(bool set)
        {
            this.isActive = set;
        }
        public bool getIsLive()
        {
            return isActive;
        }

    }
}
