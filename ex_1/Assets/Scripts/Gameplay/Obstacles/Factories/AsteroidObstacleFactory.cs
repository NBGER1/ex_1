using Gameplay.Obstacles;
using Gameplay.Obstacles.Abstractions;
using UnityEngine;

namespace GizmoLab.Gameplay
{
    public class AsteroidObstacleFactory : ObstacleFactory
    {
        #region Methods

        public override Obstacle Adjust(GameObject obstacle)
        {
            MAXHorizontalOrigin = _camera.orthographicSize / 2.5f;
            MinHorizontalOrigin = MAXHorizontalOrigin * -1;
            MinVerticalOrigin = _camera.orthographicSize;
            MaxVerticalOrigin = MinVerticalOrigin * 0.9f;

            ObstacleDataStructure obstacleData = default;
            obstacleData.Health = 25;
            obstacleData.Speed = Random.Range(2, 4);
            obstacleData.Color = Color.gray;
            obstacleData.Damage = 50;
            obstacleData.Origin = Vector3.right * Random.Range(MinHorizontalOrigin, MAXHorizontalOrigin) +
                                  Vector3.up * Random.Range(MinVerticalOrigin, MaxVerticalOrigin);
            obstacleData.Direction = Vector3.down;
            obstacleData.Constraint = _camera.orthographicSize / 2f;

            var asteroid = obstacle.GetComponent<Asteroid>();
            asteroid.Initialize(obstacleData);
            return asteroid;
        }

        #endregion
    }
}