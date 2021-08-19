using UnityEngine;

namespace Services
{
    public interface IGameplayFactories
    {
        #region Methods

        public GameObject GetBlasterProjectile();
        public GameObject GenerateRandomObstacle();

        #endregion
    }
}