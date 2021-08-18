using System;
using UnityEngine;
using Random = System.Random;

namespace GizmoLab.Gameplay.Effects
{
    public class RotatingEffect : MonoBehaviour
    {
        #region Editor

        [SerializeField] private Vector3 _rotationVector;
        [SerializeField] private GameObject _gameObject;
        [SerializeField] private float _rotationSpeed;
        [SerializeField] private bool _randomRotationSpeed;

        #endregion


        #region Methods

        private void Awake()
        {
            if (_randomRotationSpeed) _rotationSpeed = UnityEngine.Random.Range(5, 10);
            var rndX = UnityEngine.Random.Range(0f, 360f);
            var rndY = UnityEngine.Random.Range(0f, 360f);
            var rndZ = UnityEngine.Random.Range(0f, 360f);
            _gameObject.transform.rotation = Quaternion.Euler(rndX, rndY, rndZ);
        }

        public void Update()
        {
            _gameObject.transform.Rotate(_rotationVector * _rotationSpeed * Time.deltaTime);
        }

        #endregion
    }
}