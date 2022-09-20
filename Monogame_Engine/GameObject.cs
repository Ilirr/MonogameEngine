using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;
using System.Runtime.Serialization;


namespace Monogame_Engine
{
    public abstract class GameObject
    {
        public GameObject()
        {
            Components = new List<Component>();
        }
        public List<Component> Components { get; set; }

        private bool isActive;
        int id;
        string name;

        public abstract void Start();
        public virtual void Awake()
        {
            foreach (Component component in Components)
            {
                component.Awake();

            }

        }
        public virtual void Update(GameTime gameTime)
        {
            foreach (Component component in Components)
            {
                component.Update(gameTime);

            }
        }
        public virtual void Remove()
        {
            foreach (Component component in Components)
            {
                component.Remove();
            }

        }
        public virtual void Destroy()
        {
            foreach (Component component in Components)
            {
                component.Destroy();

            }

        }

        public bool IsActive
        {
            get { return isActive; }
            set
            {
                if (isActive == false && value == true)
                {
                    GameObjectManager.Instance.ActivateGameObject(this);

                }
                else if (isActive == true && value == false)
                {
                    GameObjectManager.Instance.DeactivateGameObject(this);
                }
            }

        }
        public int Id
        {
            get { return id; }
            set { if (id == 0) { id = value; }; }

        }
        public static T Instantiate<T>() where T : GameObject, new()
        {
            return GameObjectManager.Instance.CreateGameObject<T>();

        }
        public void AddComponent<T>() where T : Component, new()
        {
            T component = (T)FormatterServices.GetUninitializedObject(typeof(T));
            component.Owner = this;
            Components.Add(component);
            component.Awake();
        }
        public T GetComponent<T>() where T : Component, new()
        {

            foreach (Component component in Components)
            {
                if (component is T)
                {
                    return (T)component;
                }
            }
            return null;
        }
        public void RemoveComponent<T>() where T : Component, new()
        {

            foreach (Component component in Components)
            {
                if (component is T)
                {
                    Components.Remove(component);
                    break;
                }
            }
        }


    }
}
