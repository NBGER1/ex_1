using Core;

namespace InputControllers
{
    public interface IPlayerInput : IUpdatable
    {
        #region Methods

        void Move();
        void Fire();
        void EnableInput();
        void DisableInput();

        #endregion
    }
}