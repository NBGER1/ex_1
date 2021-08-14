﻿using System;
using UnityEngine;
using Object = UnityEngine.Object;

namespace GizmoLab.Gameplay
{
    public abstract class ObstacleFactory : MonoBehaviour
    {
        [SerializeField] private Object _obstaclePrefab;

        public virtual GameObject Create()
        {
            GameObject obstacle = Instantiate(_obstaclePrefab) as GameObject;
            return Adjust(obstacle);
        }

        public abstract GameObject Adjust(GameObject obstacle);
    }
}