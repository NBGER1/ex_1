using Gameplay.Player;
using InputControllers;
using UnityEngine;

namespace Infrastructure
{
    public class GameplayElements : Singleton<GameplayElements>
    {
        #region Editor

        [SerializeField] private Player _player;

        #endregion

        #region Functions

        protected override GameplayElements GetInstance()
        {
            return this;
        }

        #endregion

        #region Properties

        public IPlayer Player => _player;

        #endregion
    }
}