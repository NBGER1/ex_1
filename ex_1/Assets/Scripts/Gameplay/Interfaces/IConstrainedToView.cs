using UnityEngine;

namespace Gameplay.Interfaces
{
    public interface IConstrainedToView
    {
        #region Methods
        public void ValidateConstraints(Vector3 position);
        #endregion
    }
}