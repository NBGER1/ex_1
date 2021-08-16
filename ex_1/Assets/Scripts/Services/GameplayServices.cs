using Core;
using InputControllers;
using UnityEngine;

namespace Services
{
    public class GameServices
    {
        #region Fields

        private static UnityCore _unityCore;

        #endregion

        #region Methods

        public static void Initialize()
        {
            var go = new GameObject("UnityCore");
            _unityCore = go.AddComponent<UnityCore>();
            InputController inputManager = new InputController();
            _unityCore.RegisterUpdateable(inputManager);

            Object.DontDestroyOnLoad(go);
        }

        #endregion

        #region Properties

        public static IUnityCore UnityCore => _unityCore;

        public static ICoroutineService CoroutineService => _unityCore;

        #endregion
    }
}