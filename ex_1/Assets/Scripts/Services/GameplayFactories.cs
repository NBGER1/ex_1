using Gameplay.Projectiles;
using GizmoLab.Gameplay;
using UnityEngine;

namespace Services
{
    public class GameplayFactories : MonoBehaviour, IGameplayFactories
    {
        #region Fields

        private static AsteroidObstacleFactory _asteroidObstacleFactory;
        private static DebrisObstacleFactory _debrisObstacleFactory;
        private static BlasterProjectileFactory _blasterProjectileFactory;

        #endregion


        #region Methods

        private void Awake()
        {
            _asteroidObstacleFactory = gameObject.AddComponent<AsteroidObstacleFactory>();
            _debrisObstacleFactory = gameObject.AddComponent<DebrisObstacleFactory>();
            _blasterProjectileFactory = gameObject.AddComponent<BlasterProjectileFactory>();

            //# Initialize Factories with pooling
            _blasterProjectileFactory.InitializePool();
        }

        public GameObject GetBlasterProjectile()
        {
            var projectile = _blasterProjectileFactory.Create();
            return projectile;
        }

        public static GameObject GenerateRandomObstacle()
        {
            Object obstacle;
            if (Random.Range(0, 1) > 1)
            {
                obstacle = _asteroidObstacleFactory.Create();
            }
            else
            {
                obstacle = _debrisObstacleFactory.Create();
            }

            return obstacle as GameObject;
        }

        #endregion
    }
}