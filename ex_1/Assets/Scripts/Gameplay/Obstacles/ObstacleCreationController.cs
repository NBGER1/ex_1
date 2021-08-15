using System;
using System.Collections;
using UnityEngine;

namespace GizmoLab.Gameplay
{
    public class ObstacleCreationController : MonoBehaviour
    {
        #region Fields

        private AsteroidObstacleFactory _asteroidObstacleFactory;
        private DebrisObstacleFactory _debrisObstacleFactory;

        #endregion


        #region Functions

        private void Awake()
        {
            _asteroidObstacleFactory = gameObject.AddComponent<AsteroidObstacleFactory>();
            _debrisObstacleFactory = gameObject.AddComponent<DebrisObstacleFactory>();
        }

        private void Start()
        {
            CreateRandomObstacle();
        }
    
        private void CreateRandomObstacle()
        {
            if (UnityEngine.Random.Range(0, 1) > 0)
            {
                _debrisObstacleFactory.Create();
            }
            else
            {
                _asteroidObstacleFactory.Create();
            }
        }

        #endregion
    }
}