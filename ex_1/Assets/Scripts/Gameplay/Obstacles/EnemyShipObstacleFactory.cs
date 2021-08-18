using Gameplay.Obstacles;
using UnityEngine;

namespace GizmoLab.Gameplay
{
    public class EnemyShipObstacleFactory : ObstacleFactory
    {
        #region Methods

        public override GameObject Adjust(GameObject obstacle)
        {
            MAXHorizontalOrigin = Camera.main.orthographicSize / 2.5f;
            MinHorizontalOrigin = MAXHorizontalOrigin * -1;
            MinVerticalOrigin = Camera.main.orthographicSize;
            MaxVerticalOrigin = MinVerticalOrigin * 0.6f;

            ObstacleDataStructure obstacleData = default;
            obstacleData.Health = 25;
            obstacleData.Speed = UnityEngine.Random.Range(0.5f, 3f);
            obstacleData.Color = Color.yellow;
            obstacleData.Damage = 50;
            obstacleData.Origin = Vector3.right * Random.Range(MinHorizontalOrigin, MAXHorizontalOrigin) +
                                  Vector3.up * Random.Range(MinVerticalOrigin, MaxVerticalOrigin);
            obstacleData.Direction = Vector3.right;
            obstacleData.Constraint = MAXHorizontalOrigin * 1.5f;
            obstacle.GetComponent<Obstacle>().Initialize(obstacleData);
            return obstacle;
        }

        #endregion
    }
}