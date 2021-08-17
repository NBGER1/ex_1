using Services;
using UnityEngine;

namespace Boot
{
    public sealed class EntryPoint : MonoBehaviour
    {
        private void Awake()
        {
            GameplayServices.Initialize();
        }
    }
}