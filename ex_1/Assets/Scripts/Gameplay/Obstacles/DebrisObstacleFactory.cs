using Gameplay.Obstacles;
using GizmoLab.Gameplay;
using UnityEngine;

namespace GizmoLab.Gameplay
{
    public class DebrisObstacleFactory : ObstacleFactory
    {
        #region Functions

        public override GameObject Adjust(GameObject obstacle)
        {
            obstacle.GetComponent<Obstacle>().Initialize(
                Color.yellow,
                50,
                1,
                Vector3.up * 15f
            );
            return obstacle;
        }

        #endregion
    }
}