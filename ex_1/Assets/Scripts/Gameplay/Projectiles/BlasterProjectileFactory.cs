using UnityEngine;

namespace Gameplay.Projectiles
{
    public class BlasterProjectileFactory : ProjectileFactory
    {
        #region Methods

        public override GameObject Adjust(GameObject projectile)
        {
            projectile.SetActive(true);
            projectile.GetComponent<Projectile>().Initialize(
                2f,
                500f,
                1000f
            );
            return projectile;
        }

        #endregion
    }
}