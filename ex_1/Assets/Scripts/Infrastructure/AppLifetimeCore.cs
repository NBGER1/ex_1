using GizmoLab.Gameplay;
using GizmoLab.Infrastructure.Database;
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
          //  PlayerGameData.Instance.Health = 1000;
           // PlayerGameData.Instance.Score = 500;
           // PlayerGameData.Instance.Weapon = "SMG";
           // Database.LocalDataController.Instance.SaveLocalGameData("Assets/Resources/jsonData.json");
              Database.LocalDataController.Instance.LoadData("Assets/Resources/jsonData.json");
            //
        }

        private void Update()
        {
            _gameCore.Update();
        }

        #endregion
    }
}
