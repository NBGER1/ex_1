using System.Collections;
using System.Runtime.InteropServices;
using Gameplay.Interfaces;
using UnityEngine;

namespace Gameplay.Projectiles
{
    public class BlasterProjectile : Projectile
    {
        #region Fields

        private float _timeToLive;
        private float _fireForce;
        private float _damage;
        private Rigidbody _rb;

        #endregion

        #region Methods

        public void Initialize(float timeToLive, float fireForce, float damage)
        {
            _timeToLive = timeToLive;
            _fireForce = fireForce;
            _damage = damage;
            gameObject.SetActive(true);
        }


        IEnumerator HideProjectile([Optional] bool isInstant)
        {
            if (!isInstant)
                yield return new WaitForSeconds(_timeToLive);
            Debug.Log(gameObject.name + " has died after " + _timeToLive + " seconds");
            _rb.velocity = Vector3.zero;
            gameObject.SetActive(false);
        }

        private void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.CompareTag("Projectile")) return;
            other.gameObject.GetComponent<IDamageable>()?.TakeDamage(_damage);
            StartCoroutine(HideProjectile(true));
        }

        #endregion

        #region Properties

        public void Fire(Vector3 origin)
        {
            StartCoroutine(HideProjectile());
            transform.position = origin;
            _rb.AddForce(Vector3.up * _fireForce);
        }

        #endregion
    }
}