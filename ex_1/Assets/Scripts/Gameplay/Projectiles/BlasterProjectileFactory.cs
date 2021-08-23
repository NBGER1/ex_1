using System;
using UnityEngine;

namespace Gameplay.Projectiles
{
    public class BlasterProjectileFactory : ProjectileFactory
    {
        #region Methods

        private void Awake()
        {
            InitializePool();
        }

        public override Projectile Adjust(Projectile projectile)
        {
            projectile.Initialize(
                2f,
                500f,
                1000f
            );
            return projectile;
        }

        #endregion
    }
}