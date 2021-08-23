using System;
using Infrastructure;
using Infrastructure.Database;
using InputControllers;
using Services;
using UnityEngine;
using UnityEngine.PlayerLoop;
using Object = UnityEngine.Object;
using Random = UnityEngine.Random;

namespace GizmoLab.Gameplay
{
    public class AliensGameCore
    {
        #region Fields

        private int _obstaclesOnScreen = 0;
        private int _maxObstaclesOnScreen = 3;
        private float _obstacleSpawnCooldown = 2f;
        private IPlayerInput _inputController;

        #endregion


        #region Constructors

        public AliensGameCore(InputController inputController)
        {
            _inputController = inputController;
            inputController.IsEnabled = true;
            inputController.CanFire = true;
            PlayerGameData.Instance.OnPlayerDeath += OnPlayerZeroHealth;
        }

        #endregion

        #region Methods

        public void Update()
        {
            if (_obstaclesOnScreen < _maxObstaclesOnScreen)
            {
                _obstaclesOnScreen++;
                GameplayServices
                    .CoroutineService
                    .WaitFor(_obstacleSpawnCooldown)
                    .OnEnd(() =>
                    {
                        var obstacle = GameplayElements.Instance.GameplayFactories.GenerateRandomObstacle();
                        obstacle.ObjectDestroyed += OnObstacleDestroy;
                    });
            }
        }

        private void OnObstacleDestroy(object sender, EventArgs arg)
        {
            --_obstaclesOnScreen;
        }

        private void OnPlayerZeroHealth(object sneder, EventArgs arg)
        {
            Debug.Log("[Game] - Player was defeated");
        }

        #endregion

        #region Properties

        #endregion
    }
}