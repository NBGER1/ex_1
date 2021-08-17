using Gameplay.Interfaces;
using UnityEngine;

namespace Gameplay.Projectiles
{
    public abstract class ProjectileFactory : MonoBehaviour
    {
        [SerializeField] private Object _projectilePrefab;
    }
}