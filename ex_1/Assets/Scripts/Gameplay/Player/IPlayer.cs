using Gameplay.Interfaces;

namespace Gameplay.Player
{
    public interface IPlayer
    {
        #region Methods

        void Fire( );
        void Move(float force);
        #endregion

    }
}