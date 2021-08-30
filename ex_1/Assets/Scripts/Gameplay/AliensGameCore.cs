using System;
using Infrastructure;
using Infrastructure.Database;
using InputControllers;
using Services;
using UnityEditorInternal.VersionControl;
using UnityEngine;
using UnityEngine.PlayerLoop;
using Object = UnityEngine.Object;
using Random = UnityEngine.Random;

namespace GizmoLab.Gameplay
{
    public class AliensGameCore
    {
        #region Events

        #endregion

        #region Fields

        private int _obstaclesOnScreen = 0;
        private int _maxObstaclesOnScreen = 3;
        private IPlayerInput _playerInput;

        #endregion


        #region Constructors

        public AliensGameCore()
        {
            _playerInput = new InputController();
            GameplayServices.UnityCore.RegisterUpdateable(_playerInput);
            _playerInput.EnableInput();
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
                    .WaitFor(Random.Range(2, 5))
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