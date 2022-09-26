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
    public class Button : GameObject
    {
        public event EventHandler Click;
        public bool Clicked { get; private set; }

        public Color Color { get; set; }
        private Vector2 Position { get; set; }
        private Texture2D Texture;
        private SpriteFont Font;
        private string text;
        private int textSize;
        private Rectangle rectangle;

        public Button()
        {
        }
        public override void Start()
        {
            throw new NotImplementedException();
        }
        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }
        public override void Awake()
        {
            Console.WriteLine("Awake");
        }
        public override void Draw()
        {
           
        }
        public override void Destroy()
        {
            Console.WriteLine("Destroy");
        }
        public override void Remove()
        {
            Console.WriteLine("Remove");
        }

    }
}
