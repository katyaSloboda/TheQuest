﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace The_Quest_1._0
{
    abstract class Weapon : Mover
    {
        public bool PickedUp { get; private set; }

        public Weapon(Game game, Point location)
            : base(game, location)
        {
            PickedUp = false;
        }

        public void PickUpWeapon() { PickedUp = true; }
        
        public abstract string Name { get; }

        public abstract void Attack(Direction direction, Random randome);

        protected bool DamageEnemy(Direction direction, int radius,
                                   int damage, Random random)
        {
            Point target = game.PlayerLocation;
            for (int distance = 0; distance < radius; distance++)
            {
                foreach (Enemy enemy in game.Enemies)
                {
                    if (Nearby(enemy.Location, target, distance))
                    {
                        enemy.Hit(damage, random);
                        return true;
                    }
                }
                target = Move(direction, target, game.Boundaries);
            }
            return false;
        }

        private bool Nearby(Point locationToCheck, Point location, int distance)
        {
            /*if (Math.Abs(location.X - locationToCheck.X) < distance &&
                (Math.Abs(location.Y - locationToCheck.Y) < distance))
                return true;
            else
                return false;*/ // под вопросом
            base.location = location;
            return Nearby(locationToCheck, distance);
        }

        public Point Move(Direction direction, Point location, Rectangle boundaries)
        {
            base.location = location;
            return Move(direction, boundaries);
        }
    }
}
