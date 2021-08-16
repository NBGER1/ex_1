using GizmoLab.Infrastructure.Database;
using UnityEngine;

namespace Infrastructure.Database
{
    public class PlayerPrefsController : IDataManagement
    {
        #region Consts

        private const string PLAYER_PREFS_KEY = "player_data";

        #endregion

        #region Fields

        #endregion

        #region Functions

        private static PlayerGameData _LoadPlayerData()
        {
            if (!PlayerPrefs.HasKey(PLAYER_PREFS_KEY))
            {
                var defaultPlayerData = PlayerGameData.Instance;
                var defaultPlayerDataJson = JsonUtility.ToJson(defaultPlayerData);
                PlayerPrefs.SetString(PLAYER_PREFS_KEY, defaultPlayerDataJson);
            }

            var playerData = PlayerPrefs.GetString(PLAYER_PREFS_KEY);
            return JsonUtility.FromJson<PlayerGameData>(playerData);
        }

        public void SaveData(string path = null)
        {
            string playerData = JsonUtility.ToJson(PlayerGameData.Instance);
            PlayerPrefs.SetString(PLAYER_PREFS_KEY, playerData);
        }

        public void LoadData(string path = null)
        {
            PlayerGameData.Instance.Set(_LoadPlayerData());
        }

        #endregion
    }
}