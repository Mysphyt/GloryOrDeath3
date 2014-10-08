using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace GloryOrDeath4
{
    abstract class GameState
    {
        public bool done = false;

        public abstract void Update(GameTime myTime);
        public abstract void Draw(SpriteBatch myBatch);
        
        
    }
}
