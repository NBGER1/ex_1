﻿using GizmoLab.Gameplay;

namespace GizmoLab.Gameplay
{
    public class AsteroidObstacleFactory : ObstacleFactory
    {
        #region Functions

        public override Obstacle GenerateObstacle()
        {
            Obstacle obstacle = new Obstacle(500);
            return obstacle;
        }

        #endregion
    }
}