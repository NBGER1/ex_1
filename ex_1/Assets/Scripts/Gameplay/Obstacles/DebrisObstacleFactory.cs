using GizmoLab.Gameplay;
using UnityEngine;

namespace GizmoLab.Gameplay
{
    public class DebrisObstacleFactory : ObstacleFactory
    {
        #region Functions

        public override GameObject Adjust(GameObject obstacle)
        {
            obstacle.GetComponent<Renderer>().material.SetColor("_Color", Color.yellow);
            obstacle.GetComponent<Obstacle>().Health = 50;
            return obstacle;
        }

        #endregion
    }
}