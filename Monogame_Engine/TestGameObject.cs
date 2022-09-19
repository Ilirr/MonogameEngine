using Microsoft.Xna.Framework;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monogame_Engine
{
    internal class TestGameObject : GameObject
    {
        private Serilog.Core.Logger logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();

        public TestGameObject()
        {

        }
        public override void Start()
        {

        }
        public override void Update(GameTime gameTime)
        {
            logger.Debug("Update");

        }
        public override void Awake()
        {

            Console.WriteLine("Awake");
        }
        public override void Destroy()
        {

            Console.WriteLine("Destroy");

        }
        public override void Remove()
        {

            Console.WriteLine("Remove");
        }



    }
}
