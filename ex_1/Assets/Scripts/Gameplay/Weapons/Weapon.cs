using GizmoLab.Gameplay;
using UnityEngine;


public abstract class Weapon
{
    #region Fields

    protected float Cooldown;
    protected float Damage;
    protected float Ammo;

    #endregion

    #region Constructors

    protected Weapon(float ammo, float cooldown, float damage)
    {
        Cooldown = cooldown;
        Damage = damage;
        Ammo = ammo;
    }

    #endregion

    #region Functions

    #endregion
}