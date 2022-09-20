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
        public GameObject Owner { get; internal set; } //  Internal member are accessible only within the assembly by inheritance, or by instance of class


        /* public GameObject Owner
         {
             get { return Owner; }
             set { Owner = value; }
         }
        */
        public bool Initialized { get; internal set; } = false;


        private bool isActive;
        private bool visible;

        public bool Visible
        {
            get { return visible; }
            set { visible = value; }
        }

        public bool IsActive
        {
            get { return IsActive; }
            set { isActive = value; }
        }
        protected abstract void ComponentUpdate();
        public abstract void Awake();
        public abstract void Destroy();
        public abstract void Remove();
        public void Update(GameTime gameTime)
        {
            if (IsActive)
            {
                this.ComponentUpdate();
            }
        }






    }
}
