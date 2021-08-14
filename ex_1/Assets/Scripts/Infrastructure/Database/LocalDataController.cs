using UnityEngine;
using UnityEditor;
using System.IO;
using System;
using GizmoLab.Gameplay;
using Object = System.Object;

namespace GizmoLab.Infrastructure.Database
{
    public class LocalDataController : Database, ILocalDataManager
    {
        #region Consts

        private static readonly LocalDataController instance = new LocalDataController();

        #endregion

        #region Fields

        public static LocalDataController Instance
        {
            get { return instance; }
        }

        private string _path;

        #endregion

        #region Functions

        public override void SaveData()
        {
        }

        public override void LoadData()
        {
        }

        public void LoadLocalGameData(string path)
        {
            string jsonContent;
            jsonContent = File.ReadAllText(path);
            // PlayerGameData.SetGameData(JsonUtility.FromJson<Array>(jsonContent));
            PlayerGameData gamedata = PlayerGameData.Instance;
            JsonUtility.FromJson<PlayerGameData>(jsonContent);
            Debug.Log("Health loaded = " + PlayerGameData.Instance.Health);
            Debug.Log("Score loaded = " + PlayerGameData.Instance.Score);
            Debug.Log("Weapon loaded = " + PlayerGameData.Instance.Weapon);
        }

        #endregion

        #region Constructors

        private LocalDataController()
        {
        }

        #endregion
    }
}