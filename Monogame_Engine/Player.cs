using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;
using System;
using Monogame_Engine.Drawing;
using Microsoft.Xna.Framework.Content;
using System.Numerics;

namespace Monogame_Engine
{
    internal class Player : GameObject
    {
        PlayerMovement movement;
        private static readonly Lazy<Player> lazy = new Lazy<Player>(() => new Player());
        public static Player Instance { get { return lazy.Value; } }

        public Input input;
        public Player()
        {
        }

        public override void Start()
        {
            Console.WriteLine("Player.Start()");
           
            this.AddComponent<Rigidbody2D>();
            this.AddComponent<Sprite>();
            this.AddComponent<PlayerMovement>();
            m_Sprite = this.GetComponent<Sprite>();
            m_RB = this.GetComponent<Rigidbody2D>();
            movement = this.GetComponent<PlayerMovement>();

            m_Sprite.m_Texture2D = Game1.Instance.Content.Load<Texture2D>("Character");

            input = new Input();
           
        }

        public static void Update()
        {

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
