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

        private float _maxActiveDistance;
        private float _fireForce;
        private float _damage;
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

        public virtual void Fire(Vector3 origin)
        {
            _transform.position = origin;
            _startingPosition = origin;
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
            if (Vector3.Distance(_startingPosition, _transform.position) >= _maxActiveDistance) Destroy(gameObject);
        }

        #endregion

        public float Health { get; set; }
    }
}