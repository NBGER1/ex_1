using System;
using Gameplay.Interfaces;
using Gameplay.Player;
using Infrastructure;
using Infrastructure.Database;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Player : MonoBehaviour, IDamageable, IConstrainedToView, IPlayer
{
    #region Editor

    [SerializeField] private Camera _camera;
    [SerializeField] private Transform _projectileLauncher;

    #endregion

    #region Events

    #endregion

    #region Fields

    private Vector3 _spawnPosition;
    private Animator _animator;
    private Transform _transform;

    #endregion

    #region Methods

    private void Initialize()
    {
        //# Initializes itself by default
        transform.position = _spawnPosition;
        _spawnPosition = new Vector3(0, -2.2f, 0);
    }

    private void Awake()
    {
        _animator = GetComponent<Animator>();
        _transform = GetComponent<Transform>();
        Initialize();
    }

    public void ValidateConstraints(Vector3 position)
    {
        float constraint = _camera.orthographicSize / 2.5f;
        _transform.position = new Vector3(Mathf.Clamp(position.x, -1 * constraint, constraint),
            -2.2f, 0);
    }

    public void Fire()
    {
        var projectile = GameplayElements.Instance.GameplayFactories.GetProjectile(_projectileLauncher.position);
        if (projectile)
            projectile.Fire();
    }

    public void Move(float force)
    {
        float speed = force * Time.deltaTime * PlayerGameData.Instance.Speed;
        _transform.Translate(speed, -2.2f, 0);
        ValidateConstraints(_transform.position);
    }


    public void TakeDamage(float damage)
    {
        PlayerGameData.Instance.Health = Mathf.Max(PlayerGameData.Instance.Health - damage, 0);
        Debug.Log("Player took " + damage + " damage, health is now " + PlayerGameData.Instance.Health);
    }

    void IDamageable.OnZeroHealth()
    {
        return;
    }

    public float Health { get; set; }

    #endregion
}