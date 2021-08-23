using System;
using Gameplay.Interfaces;
using Gameplay.Obstacles.Abstractions;
using GizmoLab.Gameplay;
using UnityEngine;

namespace Gameplay.Obstacles
{
    public class Ship : Obstacle
    {

        #region Methods
        public override void Initialize(ObstacleDataStructure obstacleData)
        {
            _renderer.material.SetColor(Color1, obstacleData.Color);
            _health = obstacleData.Health;
            _speed = obstacleData.Speed;
            _damage = obstacleData.Damage;
            transform.position = obstacleData.Origin;
            _direction = obstacleData.Direction;
            _constraint = obstacleData.Constraint;
        }
        #endregion

    }
}