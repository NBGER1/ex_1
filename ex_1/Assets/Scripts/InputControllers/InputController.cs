using Core;
using Infrastructure;
using UnityEngine;

namespace InputControllers
{
    public class InputController : IPlayerInput, IUpdatable
    {
        #region Fields

        private bool _isEnabled;

        #endregion

        #region Methods
        public void Move()
        {
            GameplayElements.Instance.Player.Move(Input.GetAxis("Horizontal"));
        }

        public void Fire()
        {
            GameplayElements.Instance.Player.Fire();
        }

        public void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Fire();
            }

            if (Input.GetAxis("Horizontal") != 0)
            {
                Move();
            }
        }

        #endregion
    }
}