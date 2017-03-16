using Microsoft.Xna.Framework;
using Nez;
using Nez.UI;

namespace Rune_Magic.GameStates
{
    public class MainMenuState : GameState
    {
        public MainMenuState() : base()
        {
            SetUpInterface();
        }

        private void SetUpInterface()
        {
            var canvas = new UICanvas();
            var table = canvas.stage.addElement(new Table());

            // tell the table to fill all the available space. In this case that would be the entire screen.
            table.setFillParent(true);

            // if creating buttons with just colors (PrimitiveDrawables) it is important to explicitly set the minimum size since the colored textures created
            // are only 1x1 pixels
            var button = new Button(ButtonStyle.create(Color.Black, Color.DarkGray, Color.Green));
            table.add(button).setMinWidth(300).setMinHeight(80);
            var entity = Scene.createEntity("user-interface");
            entity.addComponent(canvas);
        }
    }
}