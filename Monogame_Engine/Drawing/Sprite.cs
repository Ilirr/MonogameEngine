using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;


namespace Monogame_Engine.Drawing
{
    public abstract class Sprite : Component
    {
        private Frame[] frames;
        Texture2D m_Sprite;
        Rectangle m_SourceRectangle;
        float m_Rotation;
        Color m_ColorTint;
        Vector2 Position;
        


        public Sprite() : base(null)
        {
            frames = new Frame[0];
            m_Sprite = null;
            m_SourceRectangle = new Rectangle(0, 0, 0, 0);
            m_Rotation = 0.0f;
            m_ColorTint = Color.White;
           
        }


        //Subclass (Sprite) is abstract, does not need to override Draw()
        protected override void ComponentUpdate()
        {
            Console.WriteLine("Sprite.ComponentUpdate()");

        }
        public override void Awake()
        {
            Console.WriteLine("Sprite.Awake()");
        }
        public override void Destroy()
        {
            Console.WriteLine("Sprite.Destroy()");
        }
        public override void Remove()
        {
            Console.WriteLine("Sprite.Remove()");
        }

        public void Render(SpriteBatch spriteBatch)
        {
            Console.WriteLine("Sprite.Render()");
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
