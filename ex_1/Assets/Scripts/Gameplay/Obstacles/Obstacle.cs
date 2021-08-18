using System;
using System.Linq;
using Core;
using Gameplay.Interfaces;
using Gameplay.Obstacles;
using UnityEditor.PackageManager;
using UnityEngine;

namespace GizmoLab.Gameplay
{
    public class Obstacle : MonoBehaviour, IDamageable, IUpdatable, IConstrainedToView
    {
        #region Events

        public event EventHandler ObjectDestroyed;

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
            _constraint = obstacleData.Constraint;

            Debug.Log(gameObject.name + " Was spawned at position = " + obstacleData.Origin);
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
            set { _health = value; }
        }

        #endregion
    }
}