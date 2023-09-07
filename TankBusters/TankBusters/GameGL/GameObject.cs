using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TankBusters.GameGL
{
    internal class GameObject
    {
        GameObjectType gameObjectType;
        GameCell currentCell;
        Image image;

        public GameObject()
        {

        }
        public GameObject(GameObjectType type, Image image)
        {
            this.gameObjectType = type;
            this.Image = image;
        }




        public static GameObjectType getGameObjectType(char displayCharacter)
        {

            if (displayCharacter == '.')
            {
                return GameObjectType.REWARD;
            }

            if (displayCharacter == 'p' || displayCharacter == 'P')
            {
                return GameObjectType.PLAYER;
            }
            if (displayCharacter == '%' || displayCharacter == '#')
            {
                return GameObjectType.WALL;
            }

            if (displayCharacter == '|' || displayCharacter == '@')
            {

                return GameObjectType.V_WALL;

            }
            if (displayCharacter == '$')
            {
                return GameObjectType.OBSTACLE;
            }
            if (displayCharacter == '!')
            {
                return GameObjectType.FAN;
            }

            return GameObjectType.NONE;
        }

        public GameObjectType GameObjectType { get => gameObjectType; set => gameObjectType = value; }
        public GameCell CurrentCell
        {
            get => currentCell;
            set
            {
                currentCell = value;
                currentCell.setGameObject(this);
            }
        }
        public Image Image { get => image; set => image = value; }
    }
}
