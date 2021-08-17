using GizmoLab.Gameplay.Weapons;
using GizmoLab.Infrastructure.Database;
using Infrastructure;
using Services;
using UnityEngine;

namespace GizmoLab.Gameplay
{
    public class AliensGameCore
    {
        #region Fields

        #endregion


        #region Constructors

        public AliensGameCore()
        {
            GameplayElements.Instance.Player.IsEnabled = true;
        }

        #endregion

        #region Methods

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