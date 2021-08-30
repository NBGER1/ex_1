using Core;
using Infrastructure;
using Services;
using UnityEngine;

namespace InputControllers
{
    public class InputController : IPlayerInput
    {
        #region Fields

        private bool _isEnabled;

        #endregion

        #region Methods

        public void Move()
        {
            if (!_isEnabled) return;
            GameplayElements.Instance.Player.Move(Input.GetAxis("Horizontal"));
        }

        public void Fire()
        {
            if (!_isEnabled) return;
            GameplayElements.Instance.Player.Fire();
        }

        public void EnableInput()
        {
            _isEnabled = true;
            //# Option to do other things when player input is enabled
        }

        public void DisableInput()
        {
            _isEnabled = false;
            //# Option to do other things when player input is disabled
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

        #region Properties

        public bool IsEnabled { get; set; }

        #endregion
    }
}