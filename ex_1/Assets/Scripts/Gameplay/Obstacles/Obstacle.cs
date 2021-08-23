using System;
using System.Linq;
using Core;
using Gameplay.Interfaces;
using Gameplay.Obstacles;
using UnityEngine;

namespace GizmoLab.Gameplay
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

        private void Awake()
        {
        }

        public void LateUpdate()
        {
        }

        public void Update()
        {
        }

        private void OnLeavingScreen()
        {
        }

        public void ValidateConstraints(Vector3 position)
        {
        }

        public void Initialize(ObstacleDataStructure obstacleData)
        {
        }

        public void TakeDamage(float damage)
        {
        }

        public void OnZeroHealth()
        {
        }

        private void OnCollisionEnter(Collision other)
        {
        }

        public void OnDestroy()
        {
        }

        #endregion

        #region Properties

        public float Health { get; set; }

        #endregion
    }
}