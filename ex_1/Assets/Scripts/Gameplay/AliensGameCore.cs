using GizmoLab.Gameplay.Weapons;
using GizmoLab.Infrastructure.Database;
using UnityEngine;

namespace GizmoLab.Gameplay
{
    public class AliensGameCore
    {
        #region Fields

        private Player _player;
        private IDamageable _idamageable = new Box();

        #endregion


        #region Constructors

        public AliensGameCore()
        {
            _player = new Player();
            _player.Weapon = GetPlayerWeapon(PlayerGameData.Instance.Weapon);
        }

        #endregion

        #region Functions

        private Weapon GetPlayerWeapon(string weaponName)
        {
            return new BaseCannon(100, 0.5f, 1);
        }

        public void Update()
        {
        }

        #endregion
    }
}