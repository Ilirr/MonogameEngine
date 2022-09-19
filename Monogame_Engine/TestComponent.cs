using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monogame_Engine
{
    internal class TestComponent : Component
    {
        public TestComponent() : base(null)
        {

        }

        public override void Awake()
        {
            Console.WriteLine("Component is Awake");
        }
        public override void Destroy()
        {
            Console.WriteLine("Destroy");
        }
        public override void Remove()
        {
            Console.WriteLine("Remove");
        }

        protected override void ComponentUpdate()
        {
            Console.WriteLine("ComponentUpdate");

        }
    }
}
