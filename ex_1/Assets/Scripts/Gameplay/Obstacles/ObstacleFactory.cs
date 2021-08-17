using UnityEngine;
using Object = UnityEngine.Object;

namespace Gameplay.Obstacles
{
    public abstract class ObstacleFactory : MonoBehaviour
    {
        [SerializeField] private Object _obstaclePrefab;

        public virtual GameObject Create()
        {
            Debug.Log("Instantiating a new obstacle.." + _obstaclePrefab);
            GameObject obstacle = Instantiate(_obstaclePrefab) as GameObject;
            return Adjust(obstacle);
        }

        public abstract GameObject Adjust(GameObject obstacle);
      
    }
}