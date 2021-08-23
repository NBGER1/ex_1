using Gameplay.Obstacles;
using Gameplay.Obstacles.Abstractions;
using Gameplay.Projectiles;
using GizmoLab.Gameplay;
using UnityEngine;

namespace Services
{
    public class GameplayFactories : MonoBehaviour, IGameplayFactories
    {
        #region Editor

        #region Obstacle Factories

        [SerializeField] private AsteroidObstacleFactory _asteroidObstacleFactory;
        [SerializeField] private DebrisObstacleFactory _debrisObstacleFactory;
        [SerializeField] private EnemyShipObstacleFactory _enemyShipObstacleFactory;

        #endregion

        #region Projectile Factories

        [SerializeField] private BlasterProjectileFactory _blasterProjectileFactory;

        #endregion

        #endregion

        #region Methods

        public Obstacle GenerateRandomObstacle()
        {
            Obstacle obstacle;
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

            return obstacle;
        }

        public Projectile GetProjectile(Vector3 origin)
        {
            var projectile = _blasterProjectileFactory.Create(origin);
            return projectile;
        }

        #endregion

        #region Properties

        public ObstacleFactory AsteroidObstacleFactory => _asteroidObstacleFactory;
        public ObstacleFactory DebrisObstacleFactory => _debrisObstacleFactory;
        public ObstacleFactory ShipObstacleFactory => _enemyShipObstacleFactory;
        public ProjectileFactory BlasterProjectileFactory => _blasterProjectileFactory;

        #endregion
    }
}