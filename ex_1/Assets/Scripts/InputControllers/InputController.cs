using Core;
using Infrastructure;
using Services;
using UnityEngine;

namespace InputControllers
{
    public class InputController : IPlayerInput, IUpdatable
    {
        #region Fields

        private bool _canFire;

        #endregion

        #region Constructors

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
            Debug.Log("Update of InputController");
            Debug.Log("Enabled.. do something!");

            if (Input.GetKeyDown(KeyCode.Space))
            {
                Fire();
            }

            if (Input.GetAxis("Horizontal") != 0)
            {
                Debug.Log("Moving");
                Move();
            }
        }

        #endregion
    }
}