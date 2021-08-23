using System;
using Infrastructure;
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
        private int _maxObstaclesOnScreen = 6;
        private float _obstacleSpawnCooldown = 2f;

        #endregion


        #region Constructors

        public AliensGameCore()
        {
            GameplayElements.Instance.Player.IsEnabled = true;
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

        #endregion

        #region Properties

        #endregion
    }
}