using Gameplay.Interfaces;
using Gameplay.Player;
using Gameplay.Projectiles;
using GizmoLab.Infrastructure.Database;
using Infrastructure;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Animator))]
public class Player : MonoBehaviour, IConstrainedToView, IDamageable, IPlayer
{
    #region Editor

    [SerializeField] private Camera _camera;

    #endregion

    #region Fields

    private bool _isEnabled;
    private Vector3 _spawnPosition;
    private Animator _animator;
    private Transform _transform;

    public bool IsEnabled
    {
        get { return _isEnabled; }
        set { _isEnabled = value; }
    }

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
        transform.position = new Vector3(Mathf.Clamp(position.x, -1 * constraint, constraint),
            -2.2f, 0);
    }

    public void Fire()
    {
        Vector3 _projectileSpawnPosition = transform.position + Vector3.up * 1.5f;
        var projectile = GameplayElements.Instance.GameplayFactories.GetProjectile(_projectileSpawnPosition);
        projectile.Fire(Vector3.up);
    }

    public void Move(float force)
    {
        float speed = force * Time.deltaTime * PlayerGameData.Instance.Speed;
        transform.Translate(speed, -2.2f, 0);
        ValidateConstraints(transform.position);
    }

    public void TakeDamage(float damage)
    {
        PlayerGameData.Instance.Health = Mathf.Max(PlayerGameData.Instance.Health - damage, 0);
        Debug.Log("Player took " + damage + " damage, health is now " + PlayerGameData.Instance.Health);
        if (PlayerGameData.Instance.Health == 0) OnZeroHealth();
    }

    public void OnZeroHealth()
    {
        Debug.Log("You died, but no respawn mechanism yet. Here's 100 hp");
        PlayerGameData.Instance.Health = 100;
    }

    public float Health
    {
        get { return PlayerGameData.Instance.Health; }
        set { }
    }

    #endregion
}