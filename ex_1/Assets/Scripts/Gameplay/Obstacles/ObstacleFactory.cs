using Gameplay.Interfaces;
using UnityEngine;

namespace Gameplay.Obstacles
{
    public abstract class ObstacleFactory : MonoBehaviour
    {
        #region Fields

        [SerializeField] private Object _prefab;
        protected float MAXHorizontalOrigin;
        protected float MinHorizontalOrigin;
        protected float MinVerticalOrigin;
        protected float MaxVerticalOrigin;

        #endregion

        #region Methods

        public virtual Object Create()
        {
            Debug.Log("Instantiating a new obstacle.." + _prefab);
            GameObject obstacle = Instantiate(_prefab) as GameObject;
            return Adjust(obstacle);
        }

        public abstract GameObject Adjust(GameObject obstacle);

        #endregion
    }
}