using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monogame_Engine
{
    internal sealed class Player : GameObject
    {
        private static readonly Lazy<Player> lazy = new Lazy<Player>(() => new Player());
        public static Player Instance { get { return lazy.Value; } }

        

       // public Texture2D m_Sprite = Game1.Instance.Content.Load<Texture2D>("Character");
        public Vector2 position;
        public Vector2 velocity;
        public Input input;
        private float speed = 50;
        public Player()
        {

        }
        public override void Start()
        {
            input = new Input();

            Console.WriteLine("Player.Start()");
        }
        public override void Update(GameTime gameTime)
        {
              input.lastState = input.currentState;
              input.currentState = Keyboard.GetState();

        }
        public override void Awake()
        {
            this.AddComponent<TestComponent>();
         

            Console.WriteLine("Player is Awake");
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
