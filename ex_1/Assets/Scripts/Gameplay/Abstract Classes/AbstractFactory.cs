using UnityEngine;

namespace Gameplay.Interfaces
{
    public abstract class AbstractFactory:MonoBehaviour
    {
        protected Object _prefab;
        public abstract Object Create();
        public abstract Object Adjust();
    }
}