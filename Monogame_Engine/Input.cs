using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monogame_Engine
{
    internal class Input
    {
        public KeyboardState currentState;
        public KeyboardState lastState;

        public Input()
        {
            currentState = new KeyboardState();
            lastState = new KeyboardState();
        }
        public bool IsHeld(Keys key)
        {
            if (currentState.IsKeyDown(key))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsPressed(Keys key)
        {
            if (currentState.IsKeyDown(key) && lastState.IsKeyUp(key))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsKeyUp(Keys key)
        {
            if (currentState.IsKeyUp(key) && lastState.IsKeyDown(key))
            {
                return true;
            }
            else
            {
                return false;
            }

        }


    }
}

