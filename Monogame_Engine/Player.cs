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
        private float speed = 2;
        public Player()
        {

        }
        public override void Start()
        {
            this.AddComponent<TestComponent>();
            input = new Input();

            Console.WriteLine("Player.Start()");
        }
        public override void Update(GameTime gameTime)
        {
            input.lastState = input.currentState;
            input.currentState = Keyboard.GetState();
            if(input.IsKeyUp(Keys.W))
            {
                position.Y += position.Y * speed;
            }




        }
        public override void Awake()
        {


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
