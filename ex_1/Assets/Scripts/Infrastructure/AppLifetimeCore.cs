using GizmoLab.Gameplay;
using UnityEngine;
using VSCodeEditor;

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
            Database.PlayerPrefsController.Instance.LoadData();
            Database.LocalDataController.Instance.LoadLocalGameData("Assets/Resources/jsonData.json");
            //
        }

        private void Update()
        {
            _gameCore.Update();
        }

        #endregion
    }
}
