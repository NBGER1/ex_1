using System;
using Gameplay.Projectiles.Structs;
using UnityEngine;

namespace Gameplay.Projectiles
{
    public class BlasterProjectileFactory : ProjectileFactory
    {
        #region Methods

        protected override Projectile Adjust(GameObject projectile)
        {
            var blaster = projectile.GetComponent<BlasterProjectile>();
            blaster.Initialize(_projectileData);
            return blaster;
        }

        #endregion
    }
}