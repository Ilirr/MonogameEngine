using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monogame_Engine
{
    public class PlayerMovement : Component
    {
        Player player;
        public PlayerMovement() : base(null)
        {
        }
        public override void Awake()
        {
            player = Owner as Player;
            Initialized = true;
            Console.WriteLine("PMovement.Awake()");
        }
        public override void Destroy()
        {
            Console.WriteLine("PMovement.Destroy()");

        }
        public override void Draw()
        {
            
            Console.WriteLine("PMovement.Draw()");

        }
        public override void Remove()
        {
            Console.WriteLine("PMovement.Remove()");

        }
        protected override void ComponentUpdate(GameTime gameTime)
        {
         
           float delta = (float)gameTime.ElapsedGameTime.TotalSeconds;
            player.input.lastState = player.input.currentState;
            Console.WriteLine(delta);

            player.input.currentState = Keyboard.GetState();
            if (player.input.IsHeld(Keys.W))
            {
                player.position.Y -= 100;
            }
            if (player.input.IsHeld(Keys.D))
            {
                player.position.X += player.m_RB.velocity.X * delta;
            }
            if (player.input.IsHeld(Keys.A))
            {
                player.position.X -= player.m_RB.velocity.X * delta;
            }
            if (player.input.IsHeld(Keys.S))
            {
                player.position.Y += player.m_RB.velocity.Y * delta;
            }
            player.m_RB.velocity = Vector2.Zero;
           
            

        }
    }
}
