using GizmoLab.Gameplay;
using UnityEngine;

namespace Gameplay.Obstacles
{
    public abstract class ObstacleFactory : MonoBehaviour
    {
        #region Editor

        [SerializeField] private Object _prefab;
        [SerializeField] protected Camera _camera;

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
            Debug.Log("Instantiating a new obstacle.." + _prefab);
            var obstacle = Instantiate(_prefab) as GameObject;
            return Adjust(obstacle.GetComponent<Obstacle>());
        }
    
        public abstract Obstacle Adjust(Obstacle obstacle);

        #endregion
    }
}