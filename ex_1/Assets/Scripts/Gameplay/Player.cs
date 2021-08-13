using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player 
{
    private readonly Weapon _weapon;
    public Player(Weapon weapon)
    {
        _weapon = weapon;
    }
    public void Attack(IDamageable target)
    {
        _weapon.Fire(target);
    }
    public void Reload()
    {
        _weapon.Reload();
    }
}
