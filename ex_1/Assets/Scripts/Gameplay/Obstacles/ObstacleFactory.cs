using UnityEngine;

namespace Gameplay.Obstacles
{
    public abstract class ObstacleFactory : MonoBehaviour
    {
        #region Editor

        [SerializeField] private Object _prefab;

        #endregion

        #region Fields

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

        protected abstract GameObject Adjust(GameObject obstacle);

        #endregion
    }
}