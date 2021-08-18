using System;
using System.Collections;
using System.Collections.Generic;
using Core;
using GizmoLab.Gameplay.Weapons;
using GizmoLab.Infrastructure.Database;
using Infrastructure;
using Services;
using UnityEngine;

namespace GizmoLab.Gameplay
{
    public class AliensGameCore
    {
        #region Fields

        private int _obstaclesOnScreen = 0;
        private int _maxObstaclesOnScreen = 3;
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
                        var obstacle = GameplayFactories.GenerateRandomObstacle();
                        var obsGo = obstacle.GetComponent<Obstacle>();
                        obsGo.ObjectDestroyed += OnObstacleDestroy;
                    });
            }
        }

        private void OnObstacleDestroy(object sender, EventArgs arg)
        {
            Debug.Log("Sender = " + sender.ToString() + " Has been destroyed");
            --_obstaclesOnScreen;
        }

        #endregion

        #region Properties

        #endregion
    }
}