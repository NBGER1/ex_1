using Gameplay.Interfaces;
using UnityEngine;

namespace Gameplay.Projectiles
{
    public abstract class ProjectileFactory : MonoBehaviour
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