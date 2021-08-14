using UnityEngine;

namespace GizmoLab.Gameplay
{
    public class SMG : Weapon
    {
        #region Constructors

        public SMG(float cooldown, float reloadtime, float damage) : base(cooldown, reloadtime, damage)
        {
        }

        #endregion

        #region Functions

        public override void Reload()
        {
            Debug.Log("Reloading = " + ReloadTime);
        }

        public override void Fire(IDamageable target)
        {
            Debug.Log("Firing = " + Damage);
            target.TakeDamage(Damage);
        }

        #endregion
    }
}