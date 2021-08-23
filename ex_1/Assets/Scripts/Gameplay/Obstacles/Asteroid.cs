using System;
using Gameplay.Interfaces;
using GizmoLab.Gameplay;
using UnityEngine;

namespace Gameplay.Obstacles
{
    public class Asteroid : Obstacle
    {
        #region Events

        public event EventHandler ObjectDestroyed;

        #endregion

        #region Methods

        private void Awake()
        {
            _renderer = GetComponent<Renderer>();
            _transform = GetComponent<Transform>();
        }

        public void LateUpdate()
        {
            if (_health <= 0) return;
            ValidateConstraints(transform.position);
        }

        public void Update()
        {
            if (_health <= 0) return;
            _transform.Translate(_direction * Time.deltaTime * _speed);
        }

        private void OnLeavingScreen()
        {
            Destroy(gameObject);
        }

        public void ValidateConstraints(Vector3 position)
        {
            if (position.x < _constraint * -1 || position.x > _constraint) OnLeavingScreen();
            else if (position.y < _constraint * -1 || position.y > _constraint * 3f) OnLeavingScreen();
        }

        public void Initialize(ObstacleDataStructure obstacleData)
        {
            _renderer.material.SetColor(Color1, obstacleData.Color);
            _health = obstacleData.Health;
            _speed = obstacleData.Speed;
            _damage = obstacleData.Damage;
            transform.position = obstacleData.Origin;
            _direction = obstacleData.Direction;
            _constraint = obstacleData.Constraint;
        }

        public void TakeDamage(float damage)
        {
            _health = Mathf.Max(0, _health - damage);
            Debug.Log("Obstacle took damage " + damage);
            if (_health == 0) OnZeroHealth();
        }

        public void OnZeroHealth()
        {
            Destroy(gameObject);
        }

        private void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.CompareTag("Obstacle")) return;
            other.gameObject.GetComponent<IDamageable>()?.TakeDamage(_damage);
            OnZeroHealth();
        }

        public void OnDestroy()
        {
            ObjectDestroyed?.Invoke(this, EventArgs.Empty);
        }

        #endregion

        #region Properties

        public float Health
        {
            get { return _health; }
            set { _health = Mathf.Max(value, 0); }
        }

        #endregion
    }
}