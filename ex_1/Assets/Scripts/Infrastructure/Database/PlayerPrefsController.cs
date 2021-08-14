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
            //TODO Set prefs with "Set<Type>"
        }

        public override void LoadData()
        {
            //TODO Read prefs with "Get<Type>"
        }

        #endregion

        #region Constructors

        private PlayerPrefsController()
        {
        }

        #endregion
    }
}