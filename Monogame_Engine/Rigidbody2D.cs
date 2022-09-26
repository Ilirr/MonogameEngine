using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna;
using Microsoft.Xna.Framework;
namespace Monogame_Engine
{
    public class Rigidbody2D : Component
    {

        public Vector2 velocity;

        public Rigidbody2D() : base(null)
        {

        }


        protected override void ComponentUpdate()
        {
            Console.WriteLine("Rigidbody.ComponentUpdate()");

        }
        public override void Awake()
        {
            Console.WriteLine("Rigidbody.Awake()");
        }
        public override void Destroy()
        {
            Console.WriteLine("Rigidbody.Destroy()");
        }
        public override void Remove()
        {
            Console.WriteLine("Rigidbody.Remove()");
        }
        public override void Draw()
        {
            Console.WriteLine("Rigidbody.Draw()");

        }
    }
}
