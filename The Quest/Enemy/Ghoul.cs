using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace The_Quest_1._0
{
    class Ghoul : Enemy
    {
        public Ghoul(Game game, Point point)
            : base(game, point, 10) { }

        public override void Move(Random random)
        {
            if (!Dead)
            {
                // a two in three chance that it'll move toward the player, 
                // a one in three chance that it'll stand still
                if (random.Next(3) < 2)
                    base.location = base.Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries);

                if (NearPlayer())
                    game.HitPlayer(4, random);
            }
        }
    }
}
