using System;
using Core;
using Gameplay.Interfaces;
using UnityEngine;

namespace Gameplay.Obstacles.Abstractions
{
    public abstract class Obstacle : MonoBehaviour, IDamageable, IUpdatable, IConstrainedToView
    {
        #region Events

        public event EventHandler ObjectDestroyed;

        #endregion

        #region Fields

        protected float _health;
        protected float _speed;
        protected float _damage;
        protected Vector3 _direction;
        protected static readonly int Color1;
        protected Renderer _renderer;
        protected float _constraint;
        protected Transform _transform;

        #endregion

        #region Methods

        #region Virtuals

        public virtual void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.CompareTag("Obstacle")) return;
            other.gameObject.GetComponent<IDamageable>()?.TakeDamage(_damage);
            OnZeroHealth();
        }

        public virtual void TakeDamage(float damage)
        {
            _health = Mathf.Max(0, _health - damage);
            if (_health == 0) OnZeroHealth();
        }

        public virtual void OnZeroHealth()
        {
            Destroy(gameObject);
        }

        public virtual void OnDestroy()
        {
            ObjectDestroyed?.Invoke(this, EventArgs.Empty);
        }

        public virtual void OnLeavingScreen()
        {
            Destroy(gameObject);
        }

        public virtual void Update()
        {
            _transform.Translate(_direction * Time.deltaTime * _speed);
        }

        public virtual void LateUpdate()
        {
            ValidateConstraints(transform.position);
        }

        public virtual void Awake()
        {
            _renderer = GetComponent<Renderer>();
            _transform = GetComponent<Transform>();
        }

        #endregion

        #region Abstracts

        #endregion


        public virtual void ValidateConstraints(Vector3 position)
        {
            if (position.x < _constraint * -1 || position.x > _constraint) OnLeavingScreen();
            else if (position.y < _constraint * -1 || position.y > _constraint * 3f) OnLeavingScreen();
        }

        public abstract void Initialize(ObstacleDataStructure obstacleData);

        #endregion

        #region Properties

        public virtual float Health
        {
            get { return _health; }
            set { }
        }

        #endregion
    }
}