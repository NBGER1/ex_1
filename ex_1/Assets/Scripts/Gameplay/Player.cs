using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player 
{
    #region Fields
    private readonly Weapon _weapon;
    #endregion
    
    #region Constructors
    public Player(Weapon weapon)
    {
        _weapon = weapon;
    }
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
}
