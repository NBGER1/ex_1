using GizmoLab.Gameplay;
using Infrastructure.Database;
using InputControllers;
using UnityEngine;

namespace GizmoLab.Infrastructure
{
    public class AppLifetimeCore : MonoBehaviour
    {
        #region Fields

        private AliensGameCore _gameCore;
        private IDataManagement _database;
        private InputController _inputController;

        #endregion

        #region Functions

        private void Awake()
        {
            _inputController = new InputController();
            _database = new LocalDataController();
            //_database = new PlayerPrefsController();
            _database.LoadData();
        }

        private void Start()
        {
            _gameCore = new AliensGameCore(_inputController);
        }

        private void Update()
        {
            _gameCore.Update();
        }

        #endregion
    }
}