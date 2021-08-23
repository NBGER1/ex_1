using Core;
using Infrastructure;
using Services;
using UnityEngine;

namespace InputControllers
{
    public class InputController : IPlayerInput, IUpdatable
    {
        #region Fields

        private bool _isEnabled;
        private bool _canFire;

        #endregion

        #region Methods

        public void Move()
        {
            GameplayElements.Instance.Player.Move(Input.GetAxis("Horizontal"));
        }

        public void Fire()
        {
            if (_canFire)
                _canFire = false;
            GameplayElements.Instance.Player.Fire();
            GameplayServices
                .CoroutineService
                .WaitFor(1.5f)
                .OnEnd(() => { _canFire = true; });
        }

        public void Update()
        {
            if (!_isEnabled) return;
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

        public bool IsEnabled
        {
            get { return _isEnabled; }
            set { _isEnabled = value; }
        }

        public bool CanFire { get; set; }

        #endregion
    }
}