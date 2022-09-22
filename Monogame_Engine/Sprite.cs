using Microsoft.Xna.Framework.Graphics;
using Monogame_Engine.Drawing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;


namespace Monogame_Engine
{
    public class Sprite : Component
    {
        private Frame[] frames;
        Texture2D m_Sprite;
        Rectangle m_SourceRectangle;
        float m_Rotation;
        Color m_ColorTint;
        Vector2 m_DestinationRectangle;
        Vector2 Origin;


        public Sprite() : base(null)
        {
            frames = new Frame[0];
            m_Sprite = null;
            m_SourceRectangle = new Rectangle(0, 0, 0, 0);
            m_Rotation = 0.0f;
            m_ColorTint = Color.White;
            m_DestinationRectangle = new Vector2(0, 0);
        }


        protected override void ComponentUpdate()
        {

        }
        public override void Draw()
        {
            throw new NotImplementedException();

        }
        public override void Awake()
        {
            throw new NotImplementedException();
        }
        public override void Destroy()
        {
            throw new NotImplementedException();
        }
        public override void Remove()
        {
            throw new NotImplementedException();
        }

        public void Render(SpriteBatch spriteBatch)
        {
            throw new NotImplementedException();
        }






        /*  public Sprite(Frame[] frames, int originX,int originY, string name = "")
          {

              _frames = frames;
              foreach (Frame frame in _frames)
              {
                  frame.ParentSprite = this;

              }
              Array.Copy(frames, _frames, frames.Length);

              Origin = new Vector2(originX, originY);
              Name = name;

          }
          public void Render(SpriteBatch spriteBatch)
          {

          }
          public override void Draw()
          {
              throw new NotImplementedException();
          }

          public object Clone()
          {
              var frames = new List<Frame>();
              foreach (Frame frame in _frames)
              {
                  frames.Add((Frame)frame.Clone());


              }
              var sprite = new Sprite(frames.ToArray(), (int)Origin.X, (int)Origin.Y, Name);
              sprite.Position = Position;
              //sprite.Scale = Scale;
              //sprite.Animation = Animation;
              //sprite.Rotation = Rotation;
              //sprite.Color = Color;
              return sprite;

          }

      }
        */

    }
}
