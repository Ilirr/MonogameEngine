using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;

namespace Monogame_Engine
{
    internal struct Collision
    {
        public Vector2 Position;
        public Vector2 Size;
        public Collision(Vector2 position, Vector2 size)
        {
            Position = position;
            Size = size;
        }
        //check overlap
        public bool Overlap(Collision other)
        {
            if (MathF.Abs(Position.X - other.Position.X) > Size.X + other.Size.X) return false;
            if (MathF.Abs(Position.Y - other.Position.Y) > Size.Y + other.Size.Y) return false;
            return true;
            /* return !(Position.X > other.Position.X + other.Size.X ||
                      Position.X + Size.X < other.Position.X ||
                      Position.Y > other.Position.Y + other.Size.Y ||
                      Position.Y + Size.Y < other.Position.Y);
            */


        }







    }
}
