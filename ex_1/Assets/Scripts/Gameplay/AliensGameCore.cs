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
            switch (weaponName)
            {
                case "Rifle":
                    return new Rifle(1, 1, 1);
                    break;
                case "Shotgun":
                    return new Shotgun(1, 1, 1);
                    break;
                case "SMG":
                    return new SMG(1, 1, 1);
                    break;
            }

            return new Rifle(1, 1, 1);
        }

        public void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _player.Attack(_idamageable);
            }

            if (Input.GetKeyDown(KeyCode.R))
            {
                _player.Reload();
            }
        }

        #endregion
    }
}