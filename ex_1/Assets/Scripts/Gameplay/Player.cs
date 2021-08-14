using System.Collections;
using System.Collections.Generic;
using GizmoLab.Gameplay;
using UnityEngine;

public class Player : IPlayerData
{
    #region Fields

    private Weapon _weapon;
    private float _health;
    private int _score;

    public float Health
    {
        get { return _health; }
        set
        {
            if (_health - value >= 0) _health -= value;
        }
    }

    public int Score
    {
        get { return _score; }
        set { _score += value; }
    }

    public Weapon Weapon
    {
        get { return _weapon; }
        private set { _weapon = value; }
    }

    #endregion

    #region Constructors

    public Player(Weapon weapon)
    {
        Weapon = weapon;
        Health = 100;
        Score = 0;
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