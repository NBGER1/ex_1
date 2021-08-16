using System.Collections;
using System.Collections.Generic;
using Gameplay.Player;
using GizmoLab.Gameplay;
using GizmoLab.Infrastructure.Database;
using Infrastructure.Database;
using UnityEngine;

public class Player : IDamageable, IPlayer
{
    #region Fields

    private Weapon _weapon;

    public Weapon Weapon
    {
        get { return _weapon; }
        set { _weapon = value; }
    }

    #endregion

    #region Functions

    public void Fire(IDamageable target)
    {
        //TODO: Player Fire
    }

    public void Move()
    {
        throw new System.NotImplementedException();
    }

    public void TakeDamage(float damage)
    {
        PlayerGameData.Instance.Health -= damage;
    }

    #endregion
}