using UnityEngine;

namespace Gameplay.Projectiles.Structs
{
    [CreateAssetMenu(menuName = "Projectiles/Data Object", fileName = "Projectile Data")]
    public class ProjectileData : ScriptableObject
    {
        #region Editor

        [SerializeField] [Range(0f, 1000f)] private float _damage;
        [SerializeField] [Range(0f, 1000f)] private float _launchForce;
        [SerializeField] [Range(0f, 100f)] private float _maxActiveDistance;
        
        #endregion

        #region Properties

        public float Damage => _damage;
        public float LaunchForce => _launchForce;
        public float MaxActiveDistance => _maxActiveDistance;

        #endregion
    }
}