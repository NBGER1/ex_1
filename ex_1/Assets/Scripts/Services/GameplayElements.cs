using Gameplay.Player;
using InputControllers;
using Services;
using UnityEngine;

namespace Infrastructure
{
    public class GameplayElements : Singleton<GameplayElements>
    {
        #region Editor

        [SerializeField] private Player _player;
        [SerializeField] private GameplayFactories _factories;

        #endregion

        #region Functions

        protected override GameplayElements GetInstance()
        {
            return this;
        }

        #endregion

        #region Properties

        public IPlayer Player => _player;
        public IGameplayFactories Factories => _factories;

        #endregion
    }
}