using Gameplay.Obstacles;
using GizmoLab.Gameplay;
using UnityEngine;

namespace GizmoLab.Gameplay
{
    public class AsteroidObstacleFactory : ObstacleFactory
    {
        #region Functions

        public override GameObject Adjust(GameObject obstacle)
        {
            obstacle.GetComponent<Obstacle>().Initialize(
                Color.yellow,
                100,
                1,
                50,
                Vector3.up * 15f
            );
            return obstacle;
        }

        #endregion
    }
}