using System;
using System.Linq;
using Core;
using Gameplay.Interfaces;
using Gameplay.Obstacles;
using UnityEngine;

namespace GizmoLab.Gameplay
{
    public class Obstacle : MonoBehaviour, IDamageable, IUpdatable, IConstrainedToView
    {
        #region Consts

        private float _OBSTACLE_CONSTRAINT;

        #endregion

        #region Fields

        private float _health;
        private float _speed;
        private float _damage;
        private Vector3 _direction;
        private static readonly int Color1 = Shader.PropertyToID("_Color");
        private float _constraint;

        #endregion

        #region Methods

        public void LateUpdate()
        {
            if (_health <= 0) return;
            ValidateConstraints(transform.position);
        }

        public void Update()
        {
            if (_health <= 0) return;
            transform.Translate(_direction * Time.deltaTime * _speed);
        }

        public void ValidateConstraints(Vector3 position)
        {
            if (position.x < _constraint * -1 || position.x > _constraint) OnZeroHealth();
            else if (position.y < _constraint * -1 || position.y > _constraint * 3f) OnZeroHealth();
        }

        public void Initialize(ObstacleDataStructure obstacleData)
        {
            gameObject.GetComponent<Renderer>().material.SetColor(Color1, obstacleData.Color);
            _health = obstacleData.Health;
            _speed = obstacleData.Speed;
            _damage = obstacleData.Damage;
            transform.position = obstacleData.Origin;
            _direction = obstacleData.Direction;

            //# Self initialization
            _constraint = Camera.main.orthographicSize / 1.5f;
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
    }
}