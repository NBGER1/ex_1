using System.IO;
using UnityEngine;

namespace Infrastructure.Database
{
    public class LocalDataController : IDataManagement
    {
        #region Consts

        private const string LOCAL_DATA_PATH = "Assets/Resources/PlayerData.json";

        #endregion

        #region Fields

        #endregion

        #region Methods

        public void SaveData()
        {
            var data = PlayerGameData.Instance;
            string jsonObj = JsonUtility.ToJson(data);
            File.WriteAllText(LOCAL_DATA_PATH, jsonObj);
        }

        public void LoadData()
        {
            var jsonContent = File.ReadAllText(LOCAL_DATA_PATH);
            var data = JsonUtility.FromJson<PlayerGameData>(jsonContent);

            PlayerGameData.Instance.Set(data);
        }

        #endregion
    }
}