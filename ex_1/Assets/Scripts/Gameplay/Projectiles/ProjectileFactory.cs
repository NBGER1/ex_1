using System;
using System.Collections.Generic;
using Gameplay.Projectiles.Structs;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Gameplay.Projectiles
{
    public abstract class ProjectileFactory : MonoBehaviour
    {
        #region Editor

        [SerializeField] [Range(0, 30)] protected int POOL_SIZE = 30;
        [SerializeField] private Object _prefab;
        [SerializeField] protected ProjectileData _projectileData;

        #endregion

        #region Fields

        private List<GameObject> _pool = new List<GameObject>();
        private GameObject _poolParent;

        #endregion

        #region Methods

        public virtual void Awake()
        {
            InitializePool();
        }

        public virtual void InitializePool()
        {
            _poolParent = new GameObject("ProjectilesPoolContainer");
            for (int i = 0; i < POOL_SIZE; i++)
            {
                var newProjectile = Instantiate(_prefab, _poolParent.transform, true) as GameObject;
                if (!newProjectile) continue;
                newProjectile.name = "Projectile#" + (i + 1);
                newProjectile.SetActive(false);
                _pool.Add(newProjectile);
            }
        }

        public Projectile Create(Vector3 spawnPosition)
        {
            var projectile = _pool.Find(objectInPool => !objectInPool.activeInHierarchy);
            projectile.transform.position = spawnPosition;
            return Adjust(projectile);
        }

        protected abstract Projectile Adjust(GameObject projectile);

        #endregion
    }
}