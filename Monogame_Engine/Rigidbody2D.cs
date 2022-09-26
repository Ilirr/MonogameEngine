using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monogame_Engine
{
    public class Rigidbody2D : Component
    {
        public Rigidbody2D() : base(null)
        {

        }


        protected override void ComponentUpdate()
        {
            Console.WriteLine("Sprite.ComponentUpdate()");

        }
        public override void Awake()
        {
            Console.WriteLine("Sprite.Awake()");
        }
        public override void Destroy()
        {
            Console.WriteLine("Sprite.Destroy()");
        }
        public override void Remove()
        {
            Console.WriteLine("Sprite.Remove()");
        }
        public override void Draw()
        {
            Console.WriteLine("Sprite.Draw()");

        }
    }
}
