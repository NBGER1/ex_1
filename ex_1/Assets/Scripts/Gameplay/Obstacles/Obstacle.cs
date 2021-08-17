using Gameplay.Interfaces;
using UnityEngine;

namespace GizmoLab.Gameplay
{
    public class Obstacle : MonoBehaviour, IDamageable
    {
        #region Fields

        private float _health;

        #endregion

        #region Constructors

        #endregion

        #region Methods

        public void TakeDamage(float damage)
        {
            _health = Mathf.Max(0, _health - damage);
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