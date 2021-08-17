using System;
using Core;
using Gameplay.Interfaces;
using UnityEngine;

namespace GizmoLab.Gameplay
{
    public class Obstacle : MonoBehaviour, IDamageable, IUpdatable
    {
        #region Fields

        private float _health;
        private float _speed;
        private float _damage;
        private static readonly int Color1 = Shader.PropertyToID("_Color");

        #endregion

        #region Constructors

        #endregion

        #region Methods

        public void Initialize(Color color, float health, float speed, float damage, Vector3 origin)
        {
            gameObject.GetComponent<Renderer>().material.SetColor(Color1, color);
            _health = health;
            _speed = speed;
            _damage = damage;
            transform.position = origin;
        }

        public void TakeDamage(float damage)
        {
            _health = Mathf.Max(0, _health - damage);
            if (_health == 0) OnZeroHealth();
        }

        public void OnZeroHealth()
        {
            Destroy(gameObject);
        }

        private void OnCollisionEnter(Collision other)
        {
            other.gameObject.GetComponent<IDamageable>()?.TakeDamage(_damage);
            OnZeroHealth();
        }

        #endregion

        #region Properties

        public float Health
        {
            get { return _health; }
            set { _health = value; }
        }

        #endregion

        public void Update()
        {
            transform.Translate(Vector3.down * Time.deltaTime * _speed);
        }
    }
}