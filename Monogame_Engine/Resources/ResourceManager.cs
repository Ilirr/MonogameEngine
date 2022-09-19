using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;


namespace Monogame_Engine.Resources
{
    internal class ResourceManager
    {
        private Serilog.Core.Logger logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();

        Dictionary<string, (int, object)> loadedContent = new Dictionary<string, (int, object)>();
        public ResourceManager()
        {


        }

        private static ResourceManager instance;

        public static ResourceManager Instance
        {
            get => instance;
        }

        public static ContentManager Content
        {
            get
            {
                return Game1.Instance.Content;
            }
        }
        public static void Initialize()
        {
            instance = new ResourceManager();
        }
        public static Texture2D LoadTexture(string textureName)
        {
            return Game1.Instance.Content.Load<Texture2D>(textureName);
        }
        public T GetResource<T>(string resourceName) where T : Tuple<int, object>, new()
        {

            if (loadedContent.ContainsKey(resourceName))
            {
                loadedContent[resourceName] = (loadedContent[resourceName].Item1 + 1, loadedContent[resourceName].Item2);
                return (T)loadedContent[resourceName].Item2;
            }
            else
            {
                T resource = new T();
                loadedContent.Add(resourceName, (1, resource));
                return resource;
            }
        }
        public void ReturnResource(string resourceName)
        {
            foreach (KeyValuePair<string, (int, object)> pair in loadedContent)
            {
                if (pair.Key == resourceName)
                {
                    loadedContent[resourceName] = (loadedContent[resourceName].Item1 - 1, loadedContent[resourceName].Item2);
                    if (loadedContent[resourceName].Item1 == 0)
                    {
                        Content.Unload();
                        loadedContent.Remove(resourceName);
                        logger.Information("removed resourceName");

                    }

                }
                logger.Information("Warning, no resourceName");


            }

        }
    }
}
