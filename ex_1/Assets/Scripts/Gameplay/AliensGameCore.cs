using UnityEngine;

namespace GizmoLab.Gameplay
{
    public class AliensGameCore
    {
        #region Test

        private Player _player;
        private IDamageable _idamageable = new Box();

        public AliensGameCore()

            #endregion

        {
            //Init game
            Weapon weapon = new Rifle(1, 3, 5);
            Weapon weapon2 = new Shotgun(10, 5, 10);
            _player = new Player(weapon2);
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
    }
}