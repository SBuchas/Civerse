using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Civerse
{
    abstract class GameState
    {

        protected GameStateManager gsm;

        protected GameState(GameStateManager gsm)
        {
            this.gsm = gsm;
            Init();
        }

        public abstract void Init();
        public abstract void Update(GameTime gameTime);
        public abstract void Draw();
        public abstract void HandleInput();
        public abstract void Dispose();


    }
}
