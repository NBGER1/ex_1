using System;
using UnityEngine;

namespace Infrastructure
{
    public abstract class Singleton<T> : MonoBehaviour
    {
        #region Fields

        protected static T _instance;

        #endregion

        #region Methods

        protected void Awake()
        {
            _instance = GetInstance();
        }

        protected abstract T GetInstance();

        #endregion

        #region Property

        public static T Instance
        {
            get
            {
                if (_instance == null)
                {
                    throw new InvalidCastException($"Missing instance {typeof(T)}");
                }

                return _instance;
            }
        }

        #endregion
    }
}