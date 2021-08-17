﻿using Gameplay.Obstacles;
using GizmoLab.Gameplay;
using UnityEngine;

namespace GizmoLab.Gameplay
{
    public class DebrisObstacleFactory : ObstacleFactory
    {
        #region Functions

        public override GameObject Adjust(GameObject obstacle)
        {
            ObstacleDataStructure obstacleData = default;
            obstacleData.Health = 25;
            obstacleData.Speed = 1;
            obstacleData.Color = Color.yellow;
            obstacleData.Damage = 50;
            obstacleData.Origin = Vector3.up * 15f;
            obstacleData.Direction = Vector3.down;
            obstacle.GetComponent<Obstacle>().Initialize(obstacleData);
            return obstacle;
        }

        #endregion
    }
}