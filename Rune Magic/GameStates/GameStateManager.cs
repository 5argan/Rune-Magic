namespace Rune_Magic.GameStates
{
    public class GameStateManager
    {
        private IGameState _currentState;
        private readonly Game1 _game;

        public GameStateManager(Game1 game, IGameState firstState)
        {
            _currentState = firstState;
            _game = game;
            _game.SetScene(firstState.Scene);
            firstState.OnEnter();
        }

        public void ChangeState(IGameState newState)
        {
            _currentState.OnExit();
            _currentState = newState;
            _game.SetScene(newState.Scene);
            _currentState.OnEnter();
        }
    }
}