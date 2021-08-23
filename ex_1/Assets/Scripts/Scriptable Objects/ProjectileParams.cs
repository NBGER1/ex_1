using UnityEngine;

namespace Scriptable_Objects
{
    [CreateAssetMenu(menuName = "Gameplay/Projectile/Params", fileName ="Projectile Params")]
    public class ProjectileParams : ScriptableObject
    {
        #region Editor

        [Range(0f,2f)]
        [SerializeField] private float _speed;

        #endregion

        #region Properties

        public float Speed => _speed;

        #endregion
    }
}