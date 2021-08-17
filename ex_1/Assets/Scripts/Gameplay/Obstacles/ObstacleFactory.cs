using Gameplay.Interfaces;
using UnityEngine;

namespace Gameplay.Obstacles
{
    public abstract class ObstacleFactory : MonoBehaviour
    {
        [SerializeField] private Object _prefab;

        public virtual Object Create()
        {
            Debug.Log("Instantiating a new obstacle.." + _prefab);
            GameObject obstacle = Instantiate(_prefab) as GameObject;
            return Adjust(obstacle);
        }

        public abstract GameObject Adjust(GameObject obstacle);
    }
}