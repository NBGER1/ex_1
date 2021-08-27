using GizmoLab.Gameplay;
using Infrastructure.Database;
using InputControllers;
using UnityEngine;

namespace GizmoLab.Infrastructure
{
    public class AppLifetimeCore : MonoBehaviour
    {
        #region Editor

        #endregion

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