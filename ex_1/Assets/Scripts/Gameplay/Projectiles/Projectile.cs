using UnityEngine;

namespace Gameplay.Projectiles
{
    public abstract class Projectile : MonoBehaviour
    {
        #region Fields

        private float _timeToLive;
        private float _fireForce;
        private float _damage;
        private Rigidbody _rb;

        #endregion

        #region Methods

        public void Fire(Vector3 origin)
        {
        }

        public void Initialize(float timeToLive, float fireForce, float damage)
        {
        }

        public void HideProjectile()
        {
        }

        public void HideProjectileInstant()
        {
        }

        #endregion
    }
}