using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace The_Quest_1._0
{
    class Bat : Enemy
    {
        public Bat(Game game, Point point)
            : base(game, point, 6) { }

        public override void Move(Random random)
        {
            if (!Dead)
            {
                // 50% chance that it'll move toward the player, 
                // 50% chance that it'll move in a random direction
                if (random.Next(2) == 1)
                    base.location = base.Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries);
                else
                    base.location = base.Move((Direction)random.Next(3), game.Boundaries);
                
                if (NearPlayer())
                    game.HitPlayer(2, random);
            }
        }
    }
}
