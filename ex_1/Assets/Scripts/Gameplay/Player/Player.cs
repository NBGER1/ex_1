using System;
using Gameplay.Interfaces;
using Gameplay.Player;
using Gameplay.Projectiles;
using GizmoLab.Infrastructure.Database;
using Infrastructure;
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

    #region Methods

    private void Start()
    {
    }

    public void Fire(IDamageable target)
    {
        if (!_isEnabled) return;
        Debug.Log("Player Class fire!");
        GameObject projectile = GameplayElements.Instance.Factories.GetBlasterProjectile();
        Vector3 _projectileSpawnPosition = transform.position + Vector3.up * 5f;
        projectile.GetComponent<Projectile>().Fire(_projectileSpawnPosition);
        Debug.Log("projectile = " + projectile);
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

    public float Health
    {
        get { return PlayerGameData.Instance.Health; }
        set { }
    }

    #endregion
}