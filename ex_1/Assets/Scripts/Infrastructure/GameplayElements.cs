using Infrastructure;
using UnityEngine;

namespace GizmoLab.Infrastructure
{
    public class GameplayElements : Singleton<GameplayElements>
    {
        #region Editor

        [SerializeField] private Player _player;

        #endregion

        #region Functions

        protected override GameplayElements GetInstance()
        {
            return this;
        }

        #endregion

        #region Properties
        #endregion
    }
}