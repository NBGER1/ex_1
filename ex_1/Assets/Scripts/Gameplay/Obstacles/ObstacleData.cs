using UnityEngine;

namespace Gameplay.Obstacles
{
    public struct ObstacleDataStructure
    {
        public float Health { get; set; }
        public float Damage { get; set; }
        public float Speed { get; set; }
        public Color Color { get; set; }
        public Vector3 Origin { get; set; }
        public Vector3 Direction { get; set; }
        public float Constraint { get; set; }
    }
}