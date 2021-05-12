using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace WarOfLightModule
{
    public class Creature
    {
        protected int cost;
        protected int basicGrowth;
        protected int attack;
        protected int defense;
        protected (int, int) damage;
        protected int hp;
        protected int initiative;
        protected int move;
        protected int basicShots = 0;
        protected int basicMana = 0;
        protected Bitmap bitmap;

        public int Cost
        {
            get 
            {
                if (cost == default)
                    new ArgumentException();
                return cost;
            }
        }

        public int BasicGrowth
        {
            get
            {
                if (basicGrowth == default)
                    new ArgumentException();
                return basicGrowth;
            }
        }

        public int Attack
        {
            get
            {
                if (attack == default)
                    new ArgumentException();
                return attack;
            }
        }

        public int Defense
        {
            get
            {
                if (defense == default)
                    new ArgumentException();
                return defense;
            }
        }

        public (int, int) Damage
        {
            get
            {
                if (damage == default)
                    new ArgumentException();
                return damage;
            }
        }

        public int HP
        {
            get
            {
                if (hp == default)
                    new ArgumentException();
                return hp;
            }
        }

        public int Initiative
        {
            get
            {
                if (initiative == default)
                    new ArgumentException();
                return initiative;
            }
        }

        public int Move
        {
            get
            {
                if (move == default)
                    new ArgumentException();
                return move;
            }
        }

        public int BasicShots
        {
            get
            {
                return basicShots;
            }
        }

        public void Shot()
        {
            basicShots--;
        }

        public int BasicMana
        {
            get
            {
                return basicMana;
            }
        }

        public Bitmap Bitmap
        {
            get
            {
                if(bitmap == default)
                    new ArgumentException();
                return bitmap;
            }
        }
    }
}
