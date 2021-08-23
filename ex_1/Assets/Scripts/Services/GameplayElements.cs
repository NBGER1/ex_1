using Gameplay.Obstacles;
using Gameplay.Player;
using Gameplay.Projectiles;
using InputControllers;
using Services;
using UnityEngine;

namespace Infrastructure
{
    public class GameplayElements : Singleton<GameplayElements>
    {
        #region Editor

        [SerializeField] private Player _player;
        [SerializeField] private GameplayFactories _gameplayFactories;

        #endregion

        #region Methods

        protected override GameplayElements GetInstance()
        {
            return this;
        }

        #endregion

        #region Properties

        public IPlayer Player => _player;
        public IGameplayFactories GameplayFactories => _gameplayFactories;

        #endregion
    }
}