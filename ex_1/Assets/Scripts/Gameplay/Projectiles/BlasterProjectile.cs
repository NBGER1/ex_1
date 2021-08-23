using System.Collections;
using System.Runtime.InteropServices;
using Gameplay.Interfaces;
using Gameplay.Projectiles.Structs;
using UnityEngine;

namespace Gameplay.Projectiles
{
    public class BlasterProjectile : Projectile
    {
        #region Fields

        private float _fireForce;
        private float _damage;
        private Rigidbody _rb;

        #endregion

        #region Methods

        public void Initialize(ProjectileData projectileData)
        {
            _fireForce = projectileData.LaunchForce;
            _damage = projectileData.Damage;
            gameObject.SetActive(true);
        }

        #endregion
    }
}