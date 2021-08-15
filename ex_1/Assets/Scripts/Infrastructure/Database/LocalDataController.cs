using UnityEngine;
using UnityEditor;
using System.IO;
using System;
using System.Reflection;
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

        private static object GetPropValue(object src, string propName)
        {
            return src.GetType().GetProperty(propName).GetValue(src, null);
        }

        public override void SaveData(string path)
        {
            var data = PlayerGameData.Instance;
            string jsonObj = JsonUtility.ToJson(data);
            File.WriteAllText(path, jsonObj);
        }

        public override void LoadData(string path)
        {
            string jsonContent = File.ReadAllText(path);
            GameDataFormat gdf = JsonUtility.FromJson<GameDataFormat>(jsonContent);
            PlayerGameData.Instance.Health = gdf._health;
            PlayerGameData.Instance.Score = gdf._score;
            PlayerGameData.Instance.Weapon = gdf._weapon;
            PlayerGameData.Instance.Base_Ammo = gdf._baseAmmo;
            PlayerGameData.Instance.Energy_Ammo = gdf._energyAmmo;
            PlayerGameData.Instance.Explosive_Ammo = gdf._explosiveAmmo;
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
        public float _health=100;
        public int _score=0;
        public string _weapon="";
        public int _baseAmmo=0;
        public int _explosiveAmmo=0;
        public int _energyAmmo=0;
    }
}