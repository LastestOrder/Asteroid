using System.Collections.Generic;

namespace Asteroid
{
    public sealed class GameIntialization
    {
        public GameIntialization(Controllers controllers, Data data)
        {
            var inputInitialization = new InputInitialization();
            var playerFactory = new PlayerFactory(data.Player);
            var playerInitialization = new PlayerInitialization(playerFactory, data.Player.Postion);
            var bulletInitialization =
                new BulletInitialization(Asteroid, playerInitialization.GetPlayer(), data.BulletData);

            controllers.Add(inputInitialization);
            controllers.Add(bulletInitialization);
            controllers.Add(playerInitialization);
            controllers.Add(new InputController(inputInitialization.GetInput()));
            controllers.Add(new MoveController(inputInitialization.GetInput(), playerInitialization.GetPlayer(),
                data.Player));
            
        }
    }
}