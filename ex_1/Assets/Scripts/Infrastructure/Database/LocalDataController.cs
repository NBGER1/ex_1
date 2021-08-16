using UnityEngine;
using UnityEditor;
using System.IO;
using System;
using GizmoLab.Gameplay;
using Infrastructure.Database;
using Object = System.Object;

namespace GizmoLab.Infrastructure.Database
{
    public class LocalDataController : IDataManagement
    {
        #region Consts

        private const string LOCAL_DATA_PATH = "Assets/Resources/jsonData.json";

        #endregion

        #region Fields

        #endregion

        #region Functions

        public void SaveData(string path = LOCAL_DATA_PATH)
        {
            var data = PlayerGameData.Instance;
            string jsonObj = JsonUtility.ToJson(data);
            File.WriteAllText(path, jsonObj);
        }

        public void LoadData(string path = LOCAL_DATA_PATH)
        {
            var jsonContent = File.ReadAllText(path);
            var data = JsonUtility.FromJson<PlayerGameData>(jsonContent);
            PlayerGameData.Instance.Set(data);
        }

        #endregion
    }

    /**
     * This class assists with serializing/deserializing of JSON game data
     */
    public class GameDataFormat
    {
        public float _health;
        public int _score;
        public string _weapon;
    }
}