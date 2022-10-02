using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;
using System;
using Monogame_Engine.Drawing;

namespace Monogame_Engine
{
    internal sealed class Player : GameObject
    {

        private static readonly Lazy<Player> lazy = new Lazy<Player>(() => new Player());
        public static Player Instance { get { return lazy.Value; } }

        public Input input;
        private float speed = 100;
        public Player()
        {
        }

        public override void Start()
        {
            Console.WriteLine("Player.Start()");
           
            this.AddComponent<Rigidbody2D>();
            this.AddComponent<Sprite>();
            m_Sprite = this.GetComponent<Sprite>();
            m_RB = this.GetComponent<Rigidbody2D>();
            m_Sprite.m_Texture2D = Game1.Instance.Content.Load<Texture2D>("Character");
            Console.Write("a");

            input = new Input();

        }
        public override void Update(GameTime gameTime)
        {
            float delta = (float)gameTime.ElapsedGameTime.TotalSeconds;
            input.lastState = input.currentState;
            input.currentState = Keyboard.GetState();
            if (input.IsHeld(Keys.W))
            {
                position.Y -= speed * delta;
            }
            if (input.IsHeld(Keys.D))
            {
                position.X += speed * delta;
            }
            if (input.IsHeld(Keys.A))
            {
                position.X -= speed * delta;
            }
             if (input.IsHeld(Keys.S))
            {
                position.Y += speed * delta;
            }
            System.Console.WriteLine("HA");


            m_RB.velocity = Vector2.Zero;
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
