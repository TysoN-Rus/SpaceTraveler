using CryoDI;
using UnityEngine;

namespace MyGame
{
    /// <summary>
    /// Класс, запускающий игру
    /// </summary>
    public class GameStarter : UnityStarter
    {
        private GameMain gameMain;

        //private void SetupContainer()
        //{
        //	_container = new Container();
        //	_container.RegisterType<GameMain>();
        //	_container.RegisterType<TimeSlicer>();
        //	_container.RegisterType<IInput3D, Input3D>();
        //	_container.RegisterType<IShipController, ShipController>();
        //	_container.RegisterType<IAsteroidField, AsteroidField>();
        //	_container.RegisterSceneObject<IAsteroidFactory>("AsteroidRespawn");
        //	_container.RegisterSceneObject<ISpaceShip>("Ship");
        //	_container.RegisterSceneObject<IFxPlayer>("Effects");
        //	_container.RegisterSceneObject<IMainMenu>("Interface");
        //	_container.RegisterSceneObject<IHud>("Interface");
        //}

        protected override void SetupContainer(CryoContainer container)
        {
            container.RegisterType<GameMain>();
            container.RegisterSceneObject<IContainerPanet>("Container");
            container.RegisterSceneObject<ICreator>("Creator");

            container.RegisterSceneObject<Camera>("MainCamera");
            container.RegisterSceneObject<ICameraSetting>("Container");
            container.RegisterSceneObject<ICanvasContainer>("Canvas");

            container.RegisterSingleton<IMyInput, MyInput>();

            container.RegisterSceneObject<IPlayer>("Player");
            container.RegisterSingleton<IPlayerControll, PlayerControll>();



            container.RegisterSingleton<ISpawnerPanet, SpawnerPanet>();
            container.RegisterSingleton<ICameraControll, CameraControll>();




        }
        private void Start()
        {
            gameMain = Container.Resolve<GameMain>();
        }

        private void Update()
        {
            gameMain.Update(Time.deltaTime);
        }
    }
}
