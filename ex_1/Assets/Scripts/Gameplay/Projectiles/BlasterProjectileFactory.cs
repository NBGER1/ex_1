using Gameplay.Interfaces;
using UnityEngine;

namespace Gameplay.Projectiles
{
    public class BlasterProjectileFactory : ProjectileFactory
    {
        #region Methods

        public override GameObject Adjust(GameObject projectile)
        {
            projectile.SetActive(true);
            projectile.GetComponent<Projectile>().TimeToLive = 2f;
            projectile.GetComponent<Projectile>().FireForce = 500f;
            return projectile;
        }

        #endregion
    }
}