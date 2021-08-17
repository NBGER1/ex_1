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
            GameObject obstacle = GameplayFactories.GenerateRandomObstacle();
        }

        #endregion

        #region Methods

        
        public void Update()
        {
        }

        #endregion
    }
}