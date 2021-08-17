using System;
using Gameplay.Interfaces;
using Gameplay.Player;
using Gameplay.Projectiles;
using GizmoLab.Infrastructure.Database;
using Infrastructure;
using UnityEngine;

public class Player : MonoBehaviour, IConstrainedToView, IDamageable, IPlayer
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

    public void ValidateConstraints(Vector3 position)
    {
        float constraint = Camera.main.orthographicSize / 2f;
        transform.position = new Vector3(Mathf.Clamp(position.x, -1 * constraint, constraint),
            -2.2f, 0);
    }

    public void Fire(IDamageable target)
    {
        if (!_isEnabled) return;
        GameObject projectile = GameplayElements.Instance.Factories.GetBlasterProjectile();
        Vector3 _projectileSpawnPosition = transform.position + Vector3.up * 3f;
        projectile.GetComponent<Projectile>().Fire(_projectileSpawnPosition);
    }

    public void Move(float force)
    {
        if (!_isEnabled) return;
        float speed = force * Time.deltaTime * PlayerGameData.Instance.Speed;
        transform.Translate(speed, -2.2f, 0);
        ValidateConstraints(transform.position);
    }

    public void TakeDamage(float damage)
    {
        Mathf.Max(PlayerGameData.Instance.Health - damage, 0);
        Debug.Log("[Player][" + PlayerGameData.Instance.Health + "]" + " - Was hit for " + damage);
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