using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace TankBusters.GameGL
{
    internal class Game
    {
        public static GameGrid grid;
        public static CapPrice cap;
        public static List<Tanks> bullets = new List<Tanks>();
        public static List<Makrov> enemies = new List<Makrov>();
        public static List<MakrovTanks> enemyBullets = new List<MakrovTanks>();
        public static int score = 0;
        public static int lives = 5;
        public static int enemyDamage = 1;
        public static int playerDamage = 5;
        public static int palletcount = 6;
        public static bool levelClear = false;


        public static int level      ;

        private static int rewardDelay = 0;


        public static void increaseScore(int scoreAdded)
        {
            score = score + scoreAdded;
        }




        public static GameObject getBlankGameObject()
        {
            GameObject blankGameObject = new GameObject(GameObjectType.NONE, null);
            return blankGameObject;
        }


        public static Image getGameObjectImage(char displayCharacter)
        {
            Image img = null;

            if (displayCharacter == '#' || displayCharacter == '%' || displayCharacter == '@')
            {
                img = TankBusters.Properties.Resources.wall;
            }
            if (displayCharacter == '!')
            {
                img = TankBusters.Properties.Resources.com_resize_unscreen;
            }
            if (displayCharacter == '|')
            {
                img = TankBusters.Properties.Resources.wallv;
            }
            if (displayCharacter == '$')
            {
                img = TankBusters.Properties.Resources.wallv;
            }

            if (displayCharacter == 'p' || displayCharacter == 'P')
            {
                img = TankBusters.Properties.Resources.p1;
            }
            if (displayCharacter == 'F') // enemy fire
            {
                img = TankBusters.Properties.Resources.fire_pic;
            }
            if (displayCharacter == 'Q') // player fire
            {
                img = TankBusters.Properties.Resources.image_removebg_preview__4_;
            }
            if (displayCharacter == 'h')
            {
                img = TankBusters.Properties.Resources.e1;
            }
            if (displayCharacter == 'v')
            {
                img = TankBusters.Properties.Resources.e2_flip;
            }
            if (displayCharacter == '.')
            {
                img = TankBusters.Properties.Resources.pf_picc_unscreen;
            }
            if (displayCharacter == 'x')
            {
                img = TankBusters.Properties.Resources.e3;
            }
            if (displayCharacter == 'r')
            {
                img = TankBusters.Properties.Resources.e4_flip;
            }
            return img;
        }



    }
}
