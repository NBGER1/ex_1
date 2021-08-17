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
            Debug.Log("Obstacle is = " + obstacle);
            obstacle.GetComponent<Renderer>().material.SetColor("_Color", Color.gray);
            obstacle.GetComponent<Obstacle>().Health = 500;
            obstacle.transform.position = Vector3.up;
            return obstacle;
        }

        #endregion
    }
}