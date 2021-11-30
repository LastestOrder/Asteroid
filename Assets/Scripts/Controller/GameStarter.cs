using System;
using UnityEngine;

namespace Asteroid
{
    public sealed class GameStarter : MonoBehaviour
    {
        [SerializeField] private Data _data;
        private Controllers _controllers;

        private void Start()
        {
            _controllers = new Controllers();
            new GameIntialization(_controllers, _data);
            _controllers.Initialization();
        }

        private void Update()
        {
            var deltatime = Time.deltaTime;
            _controllers.Execute(deltatime);
        }
        
        private void LateUpdate()
        {
            var deltatime = Time.deltaTime;
            _controllers.LateExecute(deltatime);
        }

        private void OnDestroy()
        {
            _controllers.Cleanup();
        }
    }
}