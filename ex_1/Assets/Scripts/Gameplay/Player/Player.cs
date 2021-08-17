using System;
using Gameplay.Interfaces;
using Gameplay.Player;
using Gameplay.Projectiles;
using GizmoLab.Infrastructure.Database;
using Infrastructure;
using UnityEngine;

public class Player : MonoBehaviour, IDamageable, IPlayer
{
    #region Const

    private float _PLAYER_CONSTRAINT;

    #endregion

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
        _PLAYER_CONSTRAINT = Camera.main.orthographicSize / 2f;
    }

    public void Fire(IDamageable target)
    {
        if (!_isEnabled) return;
        GameObject projectile = GameplayElements.Instance.Factories.GetBlasterProjectile();
        Vector3 _projectileSpawnPosition = transform.position + Vector3.up * 5f;
        projectile.GetComponent<Projectile>().Fire(_projectileSpawnPosition);
    }

    public void Move(float force)
    {
        if (!_isEnabled) return;
        float speed = force * Time.deltaTime * PlayerGameData.Instance.Speed;
        transform.Translate(speed, -2.2f, 0);
        Vector3 lastKnownPosition = transform.position;
        transform.position = new Vector3(Mathf.Clamp(lastKnownPosition.x, -1 * _PLAYER_CONSTRAINT, _PLAYER_CONSTRAINT),
            -2.2f, 0);
    }

    public void TakeDamage(float damage)
    {
        PlayerGameData.Instance.Health -= damage;
        if (PlayerGameData.Instance.Health == 0) OnZeroHealth();
    }

    public void OnZeroHealth()
    {
        Debug.Log("Player is at 0 health");
        _isEnabled = false;
    }

    public float Health
    {
        get { return PlayerGameData.Instance.Health; }
        set { }
    }

    #endregion
}