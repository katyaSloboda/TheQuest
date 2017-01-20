using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace The_Quest_1._0
{
    class Mace : Weapon
    {
        public Mace(Game game, Point point)
            : base(game, point) { }

        public override string Name { get { return "Mace"; } }

        public override void Attack(Direction direction, Random random)
        {
            for (int direct = 0; direct <= 3; direct++)
                DamageEnemy((Direction)direct, 20, 6, random);
        }
    }
}
