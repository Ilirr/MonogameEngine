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

        public Texture2D m_Sprite = Game1.Instance.Content.Load<Texture2D>("P");
        public Vector2 position;
        public Vector2 velocity;
        public bool hasJumped; // enum it
        public Input input;
        private float speed = 50;
        public Player()
        {

        }
        public override void Start()
        {
            input = new Input();

            Console.WriteLine("Start");
        }
        public override void Update(GameTime gameTime)
        {
            input.lastState = input.currentState;
            input.currentState = Keyboard.GetState();
            var delta = (float)gameTime.ElapsedGameTime.TotalSeconds;



            if (input.IsPressed(Keys.W) && hasJumped == false)
            {

                position.Y -= 10f;
                velocity.Y = -5f;
                hasJumped = true;


            }
            if (position.Y > m_Sprite.Height)
            {
                hasJumped = false;
            }
            if (hasJumped == true)
            {
                float i = 1;
                velocity.Y += 0.15f * i;


            }
            if (hasJumped == false)
            {
                velocity.Y = 0f;
            }
            if (input.IsHeld(Keys.S))
            {
                position.Y += speed;

            }
            velocity.X = 0f;
            position += velocity;


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
