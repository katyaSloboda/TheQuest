using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace The_Quest_1._0
{
    class BluePotion : Weapon, IPotion
    {
        private bool used = false;

        public BluePotion(Game game, Point point)
            : base(game, point) { }

        public override string Name { get { return "Blue Potion"; } }
        public bool Used { get { return used; } }

        public override void Attack(Direction direction, Random random)
        {
            game.IncreasePlayerHealth(5, random);
            this.used = true;
        }
    }
}
