using Gameplay.Obstacles;
using UnityEngine;

namespace GizmoLab.Gameplay
{
    public class DebrisObstacleFactory : ObstacleFactory
    {
        #region Methods

        public override Obstacle Adjust(Obstacle obstacle)
        {
            MAXHorizontalOrigin = _camera.orthographicSize / 2.5f;
            MinHorizontalOrigin = MAXHorizontalOrigin * -1;
            MinVerticalOrigin = _camera.orthographicSize;
            MaxVerticalOrigin = MinVerticalOrigin * 0.9f;

            ObstacleDataStructure obstacleData = default;
            obstacleData.Health = 25;
            obstacleData.Speed = Random.Range(3, 6);
            obstacleData.Color = Color.yellow;
            obstacleData.Damage = 50;
            obstacleData.Origin = Vector3.right * Random.Range(MinHorizontalOrigin, MAXHorizontalOrigin) +
                                  Vector3.up * Random.Range(MinVerticalOrigin, MaxVerticalOrigin);
            obstacleData.Direction = Vector3.down;
            obstacleData.Constraint = _camera.orthographicSize / 2f;
            obstacle.Initialize(obstacleData);
            return obstacle;
        }

        #endregion
    }
}