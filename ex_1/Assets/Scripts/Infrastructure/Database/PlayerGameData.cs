using System;
using UnityEngine;

namespace Infrastructure.Database
{
    [System.Serializable]
    public class PlayerGameData
    {
        #region Consts

        private static readonly PlayerGameData instance = new PlayerGameData();

        #endregion

        #region Events

        public event EventHandler OnPlayerDeath;

        #endregion

        #region Fields

        [SerializeField] private string _weapon = "";
        [SerializeField] private float _health = 0;
        [SerializeField] private int _score = 0;
        [SerializeField] private float _speed = 0;

        #endregion

        #region Properties

        public static PlayerGameData Instance => instance;


        public float Health
        {
            get => _health;
            set
            {
                _health = value;
                OnPlayerDeath?.Invoke(this, EventArgs.Empty);
            }
        }

        public int Score
        {
            get => _score;
            set => _score = value;
        }

        public float Speed
        {
            get => _speed;
            set => _speed = value;
        }

        public string Weapon
        {
            get => _weapon;
            set => _weapon = value;
        }

        #endregion


        #region Functions

        public void Set(PlayerGameData gameData)
        {
            _health = gameData.Health;
            _score = gameData.Score;
            _weapon = gameData.Weapon;
            _speed = gameData.Speed;
        }

        #endregion
    }
}