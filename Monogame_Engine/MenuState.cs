using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monogame_Engine
{
    internal class MenuState : StateManager
    {
        private List<Component> components;
        private List<GameObject> buttons;
        public MenuState(Game1 game) : base(game)
        {
            components = new List<Component>();
            var buttonTexture = game.Content.Load<Texture2D>("button");
            var buttonFont = game.Content.Load<SpriteFont>("font");

            /*var newGameButton = new Button(buttonTexture, buttonFont)
            {
                Position = new Vector2(game.GraphicsDevice.Viewport.Width / 2 - buttonTexture.Width / 2, game.GraphicsDevice.Viewport.Height / 2 - buttonTexture.Height / 2),
                Text = "New Game", 
                Click = NewGame //NewGame is a method
                

            };
            */

        }
        public override void Initialize()
        {
            throw new NotImplementedException();
        }
        public override void Draw(GameTime gameTime)
        {
            throw new NotImplementedException();

        }
        public override void LoadContent()
        {
            base.LoadContent();
            
        }
        public override void Update(GameTime gameTime)
        {
            //  base.Update(gameTime);
            foreach (Component component in components)
            {
                component.Update(gameTime);
            }
        }



    }
}
