using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Civerse
{
    class GameStateManager
    {

        //the current gameState
        private GameState gameState;

        public static readonly int MENU = 0;
        public static readonly int PLAY = 1337;

        public GameStateManager()
        {
            SetState(MENU);
        }

        public void SetState(int state)
        {
            if (gameState != null) gameState.Dispose();

            if (state == MENU)
            {
                gameState = new MenuState(this);
            }
            if (state == PLAY)
            {
                //gameState = new PlayState(this);
            }
        }

    }
}
