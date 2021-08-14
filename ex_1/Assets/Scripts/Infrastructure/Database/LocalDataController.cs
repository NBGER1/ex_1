using UnityEngine;
using UnityEditor;
using System.IO;
using System;
using GizmoLab.Gameplay;
using Object = System.Object;

namespace GizmoLab.Infrastructure.Database
{
    public class LocalDataController : Database
    {
        #region Consts

        private static readonly LocalDataController instance = new LocalDataController();

        #endregion

        #region Fields

        public static LocalDataController Instance
        {
            get { return instance; }
        }

        #endregion

        #region Functions

        public override void SaveData(string path)
        {
            var data = PlayerGameData.Instance;
            string jsonObj = JsonUtility.ToJson(data);
            File.WriteAllText(path, jsonObj);
        }

        public override void LoadData(string path)
        {
            string jsonContent;
            jsonContent = File.ReadAllText(path);
            GameDataFormat gdf = JsonUtility.FromJson<GameDataFormat>(jsonContent);
            PlayerGameData.Instance.Health = gdf._health;
            PlayerGameData.Instance.Score = gdf._score;
            PlayerGameData.Instance.Weapon = gdf._weapon;
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