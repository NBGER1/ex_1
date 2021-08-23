using UnityEngine;

namespace Gameplay.Projectiles.Structs
{
    [CreateAssetMenu(menuName = "/Projectiles/Structs", fileName = "Projectile Params")]
    public class ProjectileData : ScriptableObject
    {
        #region Editor

        [SerializeField] [Range(0f, 1000f)] private float _damage;
        [SerializeField] [Range(0f, 1000f)] private float _launchForce;

        #endregion

        #region Properties

        public float Damage => _damage;
        public float LaunchForce => _launchForce;

        #endregion
    }
}