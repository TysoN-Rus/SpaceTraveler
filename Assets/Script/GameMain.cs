using CryoDI;

namespace MyGame
{
    public class GameMain : IInitializable
    {
        [Dependency] public ICameraControll MovingCamera { private get; set; }
        [Dependency] public IPlayerControll PlayerControll { private get; set; }
        [Dependency] public ISpawnerPanet SpawnerPanet { private get; set; }

        public void Initialize()
        {
            
        }

        public void Update(float deltaTime)
        {

        }

    }
}