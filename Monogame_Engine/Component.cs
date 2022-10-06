using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;

namespace Monogame_Engine
{
    public abstract class Component
    {
        public Component(GameObject gameObject)
        {
            this.Owner = gameObject;
        }
        public GameObject Owner { get; internal set; } 

        public bool Initialized { get; internal set; } = false;


        public abstract void Draw();
        protected abstract void ComponentUpdate(GameTime gameTime);
        public abstract void Awake();
        public abstract void Destroy();
        public abstract void Remove();
        public void Update(GameTime gameTime)
        {
            if(Initialized)
            {
                
                this.ComponentUpdate(gameTime);

            }


        }






    }
}
