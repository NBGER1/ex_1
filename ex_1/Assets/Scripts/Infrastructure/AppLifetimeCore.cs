using System;
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
        private string _localDataPath = "Assets/Resources/jsonData.json";

        #endregion

        #region Functions

        private void Awake()
        {
            Database.PlayerPrefsController.Instance.LoadData();
            //# This function saves local data
            // Database.LocalDataController.Instance.SaveLocalGameData(_localDataPath);
            Database.LocalDataController.Instance.LoadData(_localDataPath);
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