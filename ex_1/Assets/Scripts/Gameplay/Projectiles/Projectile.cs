using System;
using System.Collections;
using Core;
using UnityEngine;

namespace Gameplay.Projectiles
{
    public class Projectile : MonoBehaviour
    {
        #region Fields

        private float _timeToLive;
        private float _fireForce;
        private Rigidbody _rb;

        #endregion

        #region Methods

        private void Awake()
        {
            _rb = GetComponent<Rigidbody>();
        }

        IEnumerator HideProjectile()
        {
            yield return new WaitForSeconds(_timeToLive);
            Debug.Log(gameObject.name + " has died after " + _timeToLive + " seconds");
            gameObject.SetActive(false);
        }

        #endregion

        #region Properties

        public float TimeToLive
        {
            get { return _timeToLive; }
            set { _timeToLive = value; }
        }

        public float FireForce
        {
            get { return _fireForce; }
            set { _fireForce = value; }
        }

        public void Fire(Vector3 origin)
        {
            StartCoroutine(HideProjectile());
            transform.position = origin;
            _rb.AddForce(Vector3.up * _fireForce);
        }

        #endregion
    }
}