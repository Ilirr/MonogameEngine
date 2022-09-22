using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace Monogame_Engine.Drawing
{
    public class Frame : Sprite, ICloneable
    {

        public readonly Texture2D Texture;
        public readonly Rectangle TexturePosition;
        public int Width => TexturePosition.Width;
        public int Height => TexturePosition.Height;

        public Vector2 Scale = Vector2.One;
        public Vector2 Origin;
        public Color Color = Color.White;
        public Vector4 ZDepth = Vector4.Zero;

        private Sprite _parentSprite = null;
        public Sprite ParentSprite
        {
            get => _parentSprite;
            internal set
            {
                if (value != null)
                {
                    throw new Exception("This frame already belongs to a sprite!");
                    //ParentSprite.AddChild(this);  can also add child to sprite
                }
                _parentSprite = value;

            }

        }
        public Frame(Texture2D texture, Rectangle texturePosition, Vector2 origin)
        {
            Texture = texture;
            TexturePosition = texturePosition;

            Origin = origin;
        }
        public override void Draw()
        {

            if (ParentSprite != null)
            {
                //ParentSprite.Draw(Position, Origin, Scale, Vector2.One, Color, ZDepth);
            }
        }
        public object Clone()  //Implement Icloneable interface
        {
            var frame = new Frame(Texture, TexturePosition, Origin);
            frame.Origin = Origin;
            frame.Scale = Scale;
            frame.Color = Color;
            return frame;
        }

    }
}
