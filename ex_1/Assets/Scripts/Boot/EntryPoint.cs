using Services;
using UnityEngine;

namespace Boot
{
    public class EntryPoint:MonoBehaviour
    {
        private void Awake()
        {
            GameplayServices.Initialize();
        }
    }
}