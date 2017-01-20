using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace The_Quest_1._0
{
    class Sword : Weapon
    {
        public Sword(Game game, Point point)
            : base(game, point)
        { }

        public override string Name { get { return "Sword"; } }

        public override void Attack(Direction direction, Random random)
        {
            switch (direction)
            {
                case Direction.Up:
                    AttackInDirection(Direction.Up, Direction.Left, 
                        Direction.Right, random);
                    break;
                case Direction.Down:
                    AttackInDirection(Direction.Down, Direction.Right, 
                        Direction.Left, random);
                    break;
                case Direction.Left:
                    AttackInDirection(Direction.Left, Direction.Down, 
                        Direction.Up, random);
                    break;
                case Direction.Right:
                    AttackInDirection(Direction.Right, Direction.Up, 
                        Direction.Down, random);
                    break;
                default: break;
            }
        }

        private void AttackInDirection(Direction direction, Direction left, 
                                       Direction right, Random random)
        {
            if (DamageEnemy(direction, 20, 3, random))
                return;
            else if (DamageEnemy(right, 20, 3, random))
                return;
            else DamageEnemy(left, 20, 3, random);
        }
    }
}
