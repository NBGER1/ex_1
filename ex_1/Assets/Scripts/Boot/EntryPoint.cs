using Services;
using UnityEngine;

namespace Boot
{
    public sealed class EntryPoint : MonoBehaviour
    {
        #region Methods

        private void Awake()
        {
            GameplayServices.Initialize();
        }

        #endregion
    }
}