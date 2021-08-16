using System.Collections;
using System.Collections.Generic;
using Core;
using Gameplay.Player;
using GizmoLab.Gameplay;
using GizmoLab.Infrastructure.Database;
using Infrastructure.Database;
using UnityEngine;

public class Player : MonoBehaviour, IDamageable, IPlayer
{
    #region Fields

    private bool _isEnabled;


    public bool IsEnabled
    {
        get { return _isEnabled; }
        set { _isEnabled = value; }
    }

    #endregion

    #region Functions

    public void Fire(IDamageable target)
    {
        if (!_isEnabled) return;
        Debug.Log("Player Class fire!");
    }

    public void Move(float force)
    {
        if (!_isEnabled) return;
        transform.position += Vector3.right * force * Time.deltaTime * PlayerGameData.Instance.Speed;
    }

    public void TakeDamage(float damage)
    {
        PlayerGameData.Instance.Health -= damage;
    }

    #endregion
}