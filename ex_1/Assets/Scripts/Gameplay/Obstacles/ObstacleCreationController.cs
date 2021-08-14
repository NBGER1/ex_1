using System;
using System.Collections;
using UnityEngine;

namespace GizmoLab.Gameplay
{
    public class ObstacleCreationController : MonoBehaviour
    {
        #region Fields

        private ObstacleFactory _debrisFactory, _asteroidFactory;

        #endregion

       
        #region Functions
        private void Awake()
        {
            _debrisFactory = new AsteroidObstacleFactory();
            _asteroidFactory = new DebrisObstacleFactory();
        }

        private void Start()
        {
            CreateRandomObstacle();
        }

        private void CreateRandomObstacle()
        {
            int randomObstacle = UnityEngine.Random.Range(0, 1);
            if (randomObstacle > 0)
            {
                _debrisFactory.Create();
            }
            else
            {
                _asteroidFactory.Create();
            }
        }

        #endregion
    }
}