using GizmoLab.Gameplay;
using GizmoLab.Infrastructure.Database;
using Infrastructure.Database;
using UnityEngine;

namespace GizmoLab.Infrastructure
{
    public class AppLifetimeCore : MonoBehaviour
    {
        #region Fields

        private AliensGameCore _gameCore;
        private IDataManagement _database;

        #endregion

        #region Functions

        private void Awake()
        {
            _database = new LocalDataController();
            //_database = new PlayerPrefsController();
            _database.LoadData();
        }

        private void Start()
        {
            _gameCore = new AliensGameCore();
        }

        private void Update()
        {
            _gameCore.Update();
        }

        #endregion
    }
}