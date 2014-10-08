using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GloryOrDeath4
{
    class InGame: GameState
    {
        public override void Update(Microsoft.Xna.Framework.GameTime myTime)
        {

            /*myTime.ElapsedGameTime.Milliseconds
             * //pos += velocity * gametime.elapsed.totalmillisecond;
             * Take input
             * Move players
             * move enemies
             * move projectiles
             * take collision
             * update ui
             * etc
             */
        }

        public override void Draw(Microsoft.Xna.Framework.Graphics.SpriteBatch myBatch)
        {
            /*
             * Draw background
             * Draw enemies
             * Draw players
             * Draw projectiles
             * ...
             * etc
             */
        }
    }
}
