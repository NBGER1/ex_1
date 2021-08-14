using UnityEngine;

namespace GizmoLab.Infrastructure.Database
{
    public class PlayerPrefsController : Database
    {
        #region Consts

        private static readonly PlayerPrefsController instance = new PlayerPrefsController();

        #endregion

        #region Fields

        #endregion

        public static PlayerPrefsController Instance
        {
            get { return instance; }
        }

        #region Functions

        public override void SaveData()
        {
            PlayerPrefs.SetInt("Score", PlayerGameData.Instance.Score);
            PlayerPrefs.SetFloat("Health", PlayerGameData.Instance.Health);
            PlayerPrefs.SetString("Weapon", PlayerGameData.Instance.Weapon);
        }

        public override void LoadData()
        {
            PlayerPrefs.GetInt("Score", PlayerGameData.Instance.Score);
            PlayerPrefs.GetFloat("Health", PlayerGameData.Instance.Health);
            PlayerPrefs.GetString("Weapon", PlayerGameData.Instance.Weapon);
        }

        #endregion

        #region Constructors

        private PlayerPrefsController()
        {
        }

        #endregion
    }
}