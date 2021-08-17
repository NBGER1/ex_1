using System;
using System.Collections;
using System.Runtime.InteropServices;
using Core;
using Gameplay.Interfaces;
using UnityEditor.SceneTemplate;
using UnityEngine;

namespace Gameplay.Projectiles
{
    public class Projectile : MonoBehaviour
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
        }

        private void Awake()
        {
            _rb = GetComponent<Rigidbody>();
        }

        IEnumerator HideProjectile([Optional] bool isInstant)
        {
            if (!isInstant)
                yield return new WaitForSeconds(_timeToLive);
            Debug.Log(gameObject.name + " has died after " + _timeToLive + " seconds");
            gameObject.SetActive(false);
        }

        private void OnCollisionEnter(Collision other)
        {
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