using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Nez;
using Rune_Magic.GameStates;

namespace Rune_Magic
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Core
    {
        private GameStateManager _manager;
        private MainMenuState _mainMenu;
        public Game1()
        {
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            base.Initialize();
            Window.AllowUserResizing = true;

            _mainMenu = new MainMenuState();
            _manager = new GameStateManager(this, _mainMenu);
        }

        public void SetScene(Scene newScene)
        {
            scene = newScene;
        }
    }
}
