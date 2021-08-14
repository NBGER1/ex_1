using GizmoLab.Gameplay;
using UnityEngine;

namespace GizmoLab.Infrastructure
{
    public class AppLifetimeCore : MonoBehaviour
    {
        #region Fields

        private AliensGameCore _gameCore;

        #endregion

        #region Functions

        private void Awake()
        {
            _gameCore = new AliensGameCore();
            //
        }

        private void Update()
        {
            _gameCore.Update();
        }

        #endregion
    }
}