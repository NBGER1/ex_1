namespace Gameplay.Interfaces
{
    public interface IDamageable
    {
        #region Methods

        void TakeDamage(float damage);

        #endregion

        #region Properties

        public float Health { get; set; }

        #endregion
    }
}