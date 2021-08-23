using Gameplay.Projectiles.Structs;

namespace Gameplay.Projectiles
{
    public class BlasterProjectile : Projectile
    {
        #region Methods

        public void Initialize(ProjectileData projectileData)
        {
            _fireForce = projectileData.LaunchForce;
            _damage = projectileData.Damage;
            _maxActiveDistance = projectileData.MaxActiveDistance;
            gameObject.SetActive(true);
        }

        #endregion
    }
}