using Core;
using Gameplay.Projectiles;
using InputControllers;
using UnityEngine;

namespace Services
{
    public static class GameplayServices
    {
        #region Fields

        private static UnityCore _unityCore;
        private static CoroutineService _coroutineService;

        #endregion

        #region Constructor

        static GameplayServices()
        {
            _coroutineService = CreateCoroutineCore();
        }

        #endregion

        #region Methods

        private static CoroutineService CreateCoroutineCore()
        {
            var go = new GameObject("CoroutineService_Holder");
            Object.DontDestroyOnLoad(go);
            return go.AddComponent<CoroutineService>();
        }

        public static void Initialize()
        {
            var go = new GameObject("UnityCore");
            //# Prepare Updatables
            _unityCore = go.AddComponent<UnityCore>();
            InputController inputManager = new InputController();
            //# Register Upatables
            _unityCore.RegisterUpdateable(inputManager);

            Object.DontDestroyOnLoad(go);
        }

        #endregion

        #region Properties

        public static IUnityCore UnityCore => _unityCore;

        public static ICoroutineService CoroutineService => _coroutineService;

        #endregion
    }
}