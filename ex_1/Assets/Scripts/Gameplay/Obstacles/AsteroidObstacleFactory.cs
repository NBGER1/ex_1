using GizmoLab.Gameplay;
using UnityEngine;
namespace GizmoLab.Gameplay
{
    public class AsteroidObstacleFactory : ObstacleFactory
    {
        #region Functions

        public override GameObject Adjust(GameObject obstacle)
        {
            obstacle.GetComponent<Renderer>().material.SetColor("_Color", Color.gray);
            return obstacle;
        }

        #endregion
    }
}