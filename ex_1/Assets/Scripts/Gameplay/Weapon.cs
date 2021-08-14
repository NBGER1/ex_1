using UnityEngine;


public abstract class Weapon
{
    protected float Cooldown;
    protected float ReloadTime;

    protected float Damage;

    // API for Player
    public abstract void Reload();
    public abstract void Fire(IDamageable target);

    protected Weapon(float cooldown, float reloadtime, float damage)
    {
        Cooldown = cooldown;
        ReloadTime = reloadtime;
        Damage = damage;
    }
}