using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace The_Quest_1._0
{
    class Ghost : Enemy
    {
        public Ghost(Game game, Point point)
            : base(game, point, 8) { }

        public override void Move(Random random)
        {
            if (!Dead)
            {
                // a one in three chance that it'll move toward the player, 
                // a two in three chance that it'll stand still
                if (random.Next(3) == 1)
                    base.location = base.Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries);
                
                if (NearPlayer())
                    game.HitPlayer(3, random);
            }
        }
    }
}
