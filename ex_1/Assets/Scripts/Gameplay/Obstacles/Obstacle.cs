using UnityEngine;

namespace GizmoLab.Gameplay
{
    public class Obstacle : MonoBehaviour, IDamageable
    {
        #region Fields

        private float _health;

        #endregion

        #region Constructors

        public Obstacle(float health)
        {
            _health = health;
        }

        #endregion

        #region Functions

        public void TakeDamage(float damage)
        {
            if (_health < 0) return;
            if (_health - damage >= 0)
                _health -= damage;
            else _health = 0;
        }

        #endregion

        #region Properties

        public float Health
        {
            get { return _health; }
        }

        #endregion
    }
}