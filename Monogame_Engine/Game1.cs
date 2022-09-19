using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Monogame_Engine
{
    public class Game1 : Game
    {
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
            //  GameObjectManager.Create();
            //   logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();



            base.Initialize();
        }

        protected override void LoadContent()
        {
            // player = GameObjectManager.Instance.CreateGameObject<Player>();
            //player.Awake();
            _spriteBatch = new SpriteBatch(GraphicsDevice);

        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            // GameObjectManager.Instance.Update(gameTime);

            /*  ProcessInput();  // handle input events
                UpdateGameWorld();  // update game objects
                RenderFrame();  // each render object draws itself

            */

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);


            base.Draw(gameTime);
        }
    }
}