using Gameplay.Obstacles;
using UnityEngine;

namespace GizmoLab.Gameplay
{
    public class AsteroidObstacleFactory : ObstacleFactory
    {
        #region Methods

        public override GameObject Adjust(GameObject obstacle)
        {
            MAXHorizontalOrigin = Camera.main.orthographicSize / 2.5f;
            MinHorizontalOrigin = MAXHorizontalOrigin * -1;
            MinVerticalOrigin = Camera.main.orthographicSize;
            MaxVerticalOrigin = MinVerticalOrigin * 0.9f;

            ObstacleDataStructure obstacleData = default;
            obstacleData.Health = 25;
            obstacleData.Speed = Random.Range(1, 5);
            obstacleData.Color = Color.gray;
            obstacleData.Damage = 50;
            obstacleData.Origin = Vector3.right * Random.Range(MinHorizontalOrigin, MAXHorizontalOrigin) +
                                  Vector3.up * Random.Range(MinVerticalOrigin, MaxVerticalOrigin);
            obstacleData.Direction = Vector3.down;
            obstacleData.Constraint = Camera.main.orthographicSize / 2f;

            obstacle.GetComponent<Obstacle>().Initialize(obstacleData);
            return obstacle;
        }

        #endregion
    }
}