using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GloryOrDeath4
{
    abstract class Movable
    {
        //create protected variables
        protected int health;
        public int Health
        {
            get { return health; }
            set { health = value; }
        }

    }
}
