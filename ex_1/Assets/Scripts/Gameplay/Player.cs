using System.Collections;
using System.Collections.Generic;
using GizmoLab.Gameplay;
using UnityEngine;

public class Player
{
    #region Fields

    private Weapon _weapon;

    #endregion

    #region Functions

    public void Attack(IDamageable target)
    {
        _weapon.Fire(target);
    }

    public void Reload()
    {
        _weapon.Reload();
    }

    #endregion

    #region Properties

    public Weapon Weapon
    {
        get { return _weapon; }
        set { _weapon = value; }
    }

    #endregion
}