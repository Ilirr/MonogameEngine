using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;
using Monogame_Engine.Drawing;

namespace Monogame_Engine
{
    public class Button : UISelectable
    {
        public event EventHandler Click;
        public bool Clicked { get; private set; }

        public Color Color { get; set; }
        private Vector2 Position { get; set; }
        private Texture2D Texture;
        private Font Font;
        private string text;
        private int textSize;
        private Rectangle rectangle;

        public Button()
        {
            Clicked = false;
        }

        public void OnClick()
        {

        }

    }
}
