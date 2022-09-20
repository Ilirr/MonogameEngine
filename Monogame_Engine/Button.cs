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
    public class Button : Component
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

        public Button(Rectangle rectangle, string text, Texture2D texture, SpriteFont font) : base(null)
        {
            Texture = texture;
            Font = font;
            Color = Color.White;
            Position = Vector2.Zero;
            Clicked = false;
            this.text = text;
            textSize = text.Length;



        }



        public override void Awake()
        {
            Console.WriteLine("Awake");
        }
        public override void Destroy()
        {
            Console.WriteLine("Destroy");
        }
        public override void Remove()
        {
            Console.WriteLine("Remove");
        }
        protected override void ComponentUpdate()
        {
            Console.WriteLine("ComponentUpdate");
        }
    }
}
