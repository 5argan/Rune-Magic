using Nez;

namespace Rune_Magic.GameStates
{
    public interface IGameState
    {
        Scene Scene { get; }
        void OnEnter();
        void OnExit();
    }
}