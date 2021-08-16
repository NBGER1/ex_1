using Core;
using UnityEngine;

namespace InputControllers
{
    public class InputController : IPlayerInput, IUpdatable
    {
        #region Methods

        public void Move()
        {
            throw new System.NotImplementedException();
        }

        public void Fire()
        {
            throw new System.NotImplementedException();
        }

        public void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                //TODO FIRE
            }
        }

        #endregion
    }
}