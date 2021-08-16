namespace Gameplay.Player
{
    public interface IPlayer
    {
        void Fire(IDamageable target);
        void Move();
    }
}