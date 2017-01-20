using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace The_Quest_1._0
{
    class RedPotion : Weapon, IPotion
    {
        private bool used = false;

        public RedPotion(Game game, Point point)
            : base(game, point) { }

        public override string Name { get { return "Red Potion"; } }
        public bool Used { get { return used; } }

        public override void Attack(Direction direction, Random random)
        {
            game.IncreasePlayerHealth(10, random);
            this.used = true;
        }
    }
}
