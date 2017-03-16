using Microsoft.Xna.Framework;
using Nez;

namespace Rune_Magic.GameStates
{
    public abstract class GameState : IGameState
    {
        public Scene Scene { get; }
        protected GameState()
        {
            Scene = Scene.createWithDefaultRenderer(Color.CornflowerBlue);
        }
        
        public virtual void OnEnter()
        {
        }

        public virtual void OnExit()
        {
        }
    }
}