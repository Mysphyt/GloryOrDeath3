using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GloryOrDeath4
{
    static class GraphicsManager
    {
        static Dictionary<string, Texture2D> textures = new Dictionary<string, Texture2D>();
        public static void AddTexture(string myKey, Texture2D myTexture)
        {
            textures[myKey] = myTexture;
        }
        public static Texture2D GetTexture(string myKey)
        {
            if (DoesContainTexture(myKey))
                return textures[myKey];
            else
                return textures["default"];
        }
        public static Boolean DoesContainTexture(string myKey)
        {
            return textures.ContainsKey(myKey);
        }
    }
}
