using UnityEngine;

namespace GizmoLab.Gameplay
{
    public class Shotgun : Weapon
    {
        public override void Reload()
        {
            Debug.Log("Reloading = " + ReloadTime);
        }

        public override void Fire(IDamageable target)
        {
            Debug.Log("Firing = " + Damage);
            target.TakeDamage(Damage);
        }

        public Shotgun(float cooldown, float reloadtime, float damage) : base(cooldown, reloadtime, damage)
        {
        }
    }
}