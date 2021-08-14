using UnityEngine;


public abstract class Weapon
{
    #region Fields

    protected float Cooldown;
    protected float ReloadTime;
    protected float Damage;

    #endregion

    #region Constructors

    protected Weapon(float cooldown, float reloadtime, float damage)
    {
        Cooldown = cooldown;
        ReloadTime = reloadtime;
        Damage = damage;
    }

    #endregion

    #region Functions

    public abstract void Reload();
    public abstract void Fire(IDamageable target);

    #endregion
}