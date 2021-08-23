namespace InputControllers
{
    public interface IPlayerInput
    {
        #region Methods

        public abstract void Move();
        public abstract void Fire();

        #endregion

        #region Properties

        public abstract bool IsEnabled { get; set; }
        public abstract bool CanFire { get; set; }

        #endregion
    }
}