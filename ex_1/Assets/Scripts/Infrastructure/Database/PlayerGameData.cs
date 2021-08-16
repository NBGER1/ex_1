using UnityEngine;

namespace GizmoLab.Infrastructure.Database
{
    [System.Serializable]
    public class PlayerGameData
    {
        #region Consts

        private static readonly PlayerGameData instance = new PlayerGameData();

        #endregion

        #region Fields

        [SerializeField] private string _weapon = "";
        [SerializeField] private float _health = 0;
        [SerializeField] private int _score = 0;

        #endregion

        #region Properties

        public static PlayerGameData Instance
        {
            get { return instance; }
        }


        public float Health
        {
            get { return _health; }
            set { _health = value; }
        }

        public int Score
        {
            get { return _score; }
            set { _score = value; }
        }


        public string Weapon
        {
            get { return _weapon; }
            set { _weapon = value; }
        }

        #endregion

        #region Functions

        public void Set(PlayerGameData gameData)
        {
            _health = gameData.Health;
            _score = gameData.Score;
            _weapon = gameData.Weapon;
        }

        #endregion
    }
}