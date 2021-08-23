using Gameplay.Obstacles.Abstractions;
using UnityEngine;

namespace Gameplay.Obstacles
{
    public abstract class ObstacleFactory : MonoBehaviour
    {
        #region Editor

        [SerializeField] protected Camera _camera;
        [SerializeField] private Object _prfefab;

        #endregion

        #region Fields

        protected float MAXHorizontalOrigin;
        protected float MinHorizontalOrigin;
        protected float MinVerticalOrigin;
        protected float MaxVerticalOrigin;

        #endregion

        #region Methods

        public virtual Obstacle Create()
        {
            GameObject obstacle = Instantiate(_prfefab) as GameObject;
            return Adjust(obstacle);
        }

        public abstract Obstacle Adjust(GameObject obstacle);

        #endregion
    }
}