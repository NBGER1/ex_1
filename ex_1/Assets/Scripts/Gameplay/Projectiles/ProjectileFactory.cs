using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Gameplay.Projectiles
{
    public abstract class ProjectileFactory : MonoBehaviour
    {
        #region Consts

        private const int POOL_SIZE = 30;

        #endregion

        #region Fields

        [SerializeField] private Object _prefab;
        private List<GameObject> _pool = new List<GameObject>();
        private GameObject _poolParent;

        #endregion

        #region Methods

        public void InitializePool()
        {
            _poolParent = new GameObject("ProjectilePool");
            for (int i = 0; i < POOL_SIZE; i++)
            {
                var newProjectile = Instantiate(_prefab, _poolParent.transform, true) as GameObject;
                newProjectile.name = "Projectile#" + (i + 1);
                newProjectile.SetActive(false);
                _pool.Add(newProjectile);
            }
        }

        public GameObject Create()
        {
            GameObject projectile = _pool.Find(objectInPool => !objectInPool.activeInHierarchy);
            Debug.Log("Creating projectile = " + projectile.name);
            return Adjust(projectile);
        }

        public abstract GameObject Adjust(GameObject obstacle);

        #endregion
    }
}