using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Core
{
    public class UnityCore : MonoBehaviour, IUnityCore
    {
        #region Fields

        private IList<IUpdatable> _updatables =
            new List<IUpdatable>();

        #endregion

        #region Methods

        private void Update()
        {
            for (var i = 0; i < _updatables.Count; i++)
            {
                _updatables[i].Update();
            }
        }


        public void RegisterUpdateable(IUpdatable updatable)
        {
            _updatables.Add(updatable);
        }

        #endregion
    }
}