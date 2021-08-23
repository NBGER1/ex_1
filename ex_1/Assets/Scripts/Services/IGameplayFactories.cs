using Gameplay.Projectiles;
using GizmoLab.Gameplay;
using UnityEngine;

namespace Services
{
    public interface IGameplayFactories
    {
        #region Methods

        public Obstacle GenerateRandomObstacle();
        public Projectile GetProjectile(Vector3 origin);

        #endregion
    }
}