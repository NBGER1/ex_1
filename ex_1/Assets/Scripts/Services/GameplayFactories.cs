using Gameplay.Projectiles;
using GizmoLab.Gameplay;
using UnityEngine;

namespace Services
{
    public class GameplayFactories : MonoBehaviour, IGameplayFactories
    {
        #region Fields

        private AsteroidObstacleFactory _asteroidObstacleFactory;
        private DebrisObstacleFactory _debrisObstacleFactory;
        private BlasterProjectileFactory _blasterProjectileFactory;

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
            Debug.Log("GetBlasterProjectile @GameplayFactories");
            var projectile = _blasterProjectileFactory.Create();
            return projectile;
        }

        #endregion
    }
}