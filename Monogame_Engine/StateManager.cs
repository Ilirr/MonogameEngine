using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monogame_Engine
{
    internal abstract class StateManager
    {
        #region Fields
        protected ContentManager content;

        protected GraphicsDevice graphicsDevice;

        protected Game1 game;

        #endregion
        #region Properties
        public ContentManager Content
        {
            get { return content; }
        }
        public GraphicsDevice GraphicsDevice
        {
            get { return graphicsDevice; }
        }
        public Game1 Game
        {
            get { return game; }
        }
        #endregion
        #region Constructors
        public StateManager(Game1 game)
        {
            this.game = game;
            this.graphicsDevice = game.GraphicsDevice;
            this.content = game.Content;
        }
        #endregion
        #region Methods
        public abstract void Initialize();
        public virtual void LoadContent()
        {


        }
        public abstract void Update(GameTime gameTime);
        public abstract void Draw(GameTime gameTime);
        #endregion

    }
    /*
     * #region Methods
    public abstract void Update(GameTime gameTime);
    public abstract void Draw(GameTime gameTime, SpriteBatch spriteBatch);

    public StateManager(Game1 game, GraphicsDevice graphicsDevice, ContentManager content)
    {


        this.game = game;
        this.graphicsDevice = graphicsDevice;
        this.content = content;

    }

    #endregion
     * 
     * 
     * 
     * 
     */
}
