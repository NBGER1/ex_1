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
        private static EnemyShipObstacleFactory _enemyShipObstacleFactory;

        #endregion


        #region Methods

        private void Awake()
        {
            //# Obstacles
            _asteroidObstacleFactory = gameObject.AddComponent<AsteroidObstacleFactory>();
            _debrisObstacleFactory = gameObject.AddComponent<DebrisObstacleFactory>();
            _enemyShipObstacleFactory = gameObject.AddComponent<EnemyShipObstacleFactory>();
            //# Projectiles
            _blasterProjectileFactory = gameObject.AddComponent<BlasterProjectileFactory>();

            //# Initialize Factories with pooling
            _blasterProjectileFactory.InitializePool();
        }

        public GameObject GetBlasterProjectile()
        {
            var projectile = _blasterProjectileFactory.Create();
            return projectile;
        }

        public GameObject GenerateRandomObstacle()
        {
            Object obstacle;
            var rnd = Random.Range(0, 3);
            if (rnd == 0)
            {
                obstacle = _asteroidObstacleFactory.Create();
            }
            else if (rnd == 1)
            {
                obstacle = _debrisObstacleFactory.Create();
            }
            else
            {
                obstacle = _enemyShipObstacleFactory.Create();
            }

            return obstacle as GameObject;
        }

        #endregion
    }
}