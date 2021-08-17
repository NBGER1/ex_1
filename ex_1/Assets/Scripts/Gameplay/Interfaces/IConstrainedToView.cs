using UnityEngine;

namespace Gameplay.Interfaces
{
    public interface IConstrainedToView
    {
        public void ValidateConstraints(Vector3 position);
    }
}