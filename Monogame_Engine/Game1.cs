using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Serilog.Configuration;
using Serilog;
using Serilog.Debugging;
using Monogame_Engine.Drawing;

namespace Monogame_Engine
{
    public class Game1 : Game
    {
        private static Serilog.Core.Logger logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        public static Game1 Instance { get; private set; }

        public Game1()
        {
            Instance = this;
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            this.IsFixedTimeStep = true;
          

        }
        
        protected override void Initialize()
        {
              GameObjectManager.Create();
             GameObjectManager.Instance.CreateGameObject<Player>();
             logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();



            base.Initialize();
        }

        protected override void LoadContent()
        {
     
            _spriteBatch = new SpriteBatch(GraphicsDevice);

    }

    protected override void Update(GameTime gameTime)
        {

            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
             GameObjectManager.Instance.Update(gameTime);
            /*  
                RenderFrame();  // each render object draws itself

            */
            Player.Update();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            _spriteBatch.Begin();
            GameObjectManager.Instance.Render(_spriteBatch);
            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}