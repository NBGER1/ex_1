using System;
using Core;
using Gameplay.Interfaces;
using Services;
using UnityEngine;

namespace Gameplay.Projectiles
{
    public abstract class Projectile : MonoBehaviour
    {
        #region Editor

        #endregion

        #region Fields

        protected float _maxActiveDistance;
        protected float _fireForce;
        protected float _damage;
        private Rigidbody _rb;
        private Transform _transform;
        private Vector3 _startingPosition;
        
        #endregion

        #region Methods

        public void Awake()
        {
            _transform = transform;
            _rb = gameObject.GetComponent<Rigidbody>();
        }

        public virtual void Fire()
        {
            _startingPosition = _transform.position;
            _rb.AddForce(Vector3.up * _fireForce);
        }

        public virtual void HideProjectile()
        {
            gameObject.SetActive(false);
        }

        public virtual void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.CompareTag("Projectile")) return;
            other.gameObject.GetComponent<IDamageable>()?.TakeDamage(_damage);
        }

        public void LateUpdate()
        {
            if (Vector3.Distance(_startingPosition, _transform.position) >= _maxActiveDistance)
                HideProjectile();
        }

        #endregion

        public float Health { get; set; }
    }
}