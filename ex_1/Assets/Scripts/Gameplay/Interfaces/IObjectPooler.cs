using UnityEngine;

namespace Gameplay.Interfaces
{
    public interface IObjectPooler
    {
        #region Methods

        void Initialize();
        void ResetAllObjects();
        void HideObject(Object other);
        Object GetObject();

        #endregion
    }
}