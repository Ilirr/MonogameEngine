using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using System.Runtime.CompilerServices;

namespace Monogame_Engine.Drawing
{
    public class Sprite : Component
    {
        private Frame[] frames;


        public Texture2D m_Texture2D;
        public Rectangle m_SourceRectangle;


        public float m_Rotation;
        public Color m_ColorTint;


        public Vector2 Position;



        public Sprite() : base(null)
        {

        }


        //Subclass (Sprite) is abstract, does not need to override Draw()
        protected override void ComponentUpdate(GameTime gameTime)
        {
        }
        public override void Awake()
        {
            Initialized = true;
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
        public override void Draw()
        {
            Console.WriteLine("Sprite.Draw()");

        }

        public void Render(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Owner.m_Sprite.m_Texture2D, Owner.position, Color.White);

        }
    }
}
