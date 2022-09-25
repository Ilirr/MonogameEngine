using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monogame_Engine
{
    internal class GameObjectManager
    {
        private Serilog.Core.Logger logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();

        private List<GameObject> activeGameObjects = new List<GameObject>();
        LinkedList<GameObject> inactiveGameObjects = new LinkedList<GameObject>();
        LinkedList<GameObject> addedGameObjects = new LinkedList<GameObject>();
        LinkedList<GameObject> removedGameObjects = new LinkedList<GameObject>();
        private int currentGameObjectId;

        private static GameObjectManager instance;
        public static GameObjectManager Instance
        {
            get => instance;
        }

        public static void Create()
        {
            if (instance == null)
            {
                instance = new GameObjectManager();
            }

        }
        public void ActivateGameObject(GameObject gameObject)
        {
            if (inactiveGameObjects.Contains(gameObject))
            {
                gameObject.Awake();
                activeGameObjects.Add(gameObject);
                inactiveGameObjects.Remove(gameObject);

            }
        }
        public void DeactivateGameObject(GameObject gameObject)
        {
            if (activeGameObjects.Contains(gameObject))
            {
                gameObject.Destroy();
                activeGameObjects.Remove(gameObject);
                inactiveGameObjects.AddLast(gameObject);
            }
        }
        public void QueueRemoveObject(GameObject gameObject)
        {
            removedGameObjects.AddLast(gameObject);

        }
        public T CreateGameObject<T>() where T : GameObject, new()
        {
            T gameObject = new T();
            gameObject.Id = currentGameObjectId;
            currentGameObjectId++;
            addedGameObjects.AddLast(gameObject);
            return gameObject;

        }
        public void Update(GameTime gameTime)
        {
            foreach (GameObject gameObject in removedGameObjects)
            {
                gameObject.Remove();
                activeGameObjects.Remove(gameObject);

            }
            removedGameObjects.Clear();
            foreach (GameObject gameObject in addedGameObjects)
            {
                gameObject.Start();
                activeGameObjects.Add(gameObject);
            }
            addedGameObjects.Clear();
            foreach (GameObject gameObject in activeGameObjects)
            {
                gameObject.Update(gameTime);
            }

        }
        public void Draw(SpriteBatch batch)
        {
            foreach (GameObject gameObject in activeGameObjects)
            {
                gameObject.Draw();

            }

        }


    }
}
