namespace Gameplay.Player
{
    public interface IPlayer
    {
        #region Methods

        void Fire(IDamageable target);
        void Move(float force);

        #endregion

        #region Properties

        public bool IsEnabled { get; set; }

        #endregion
    }
}