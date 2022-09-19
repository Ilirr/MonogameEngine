using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;

namespace Monogame_Engine.Drawing
{
    public abstract class Drawable
    {

        public Vector2 Position;
        public abstract void Draw();
    }
}
