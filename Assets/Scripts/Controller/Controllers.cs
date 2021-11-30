﻿using System.Collections.Generic;

namespace Asteroid
{
    public sealed class Controllers: IInitialization, IExecute, ILateExecute, ICleanup
    {
        private readonly List<IInitialization> _initializeControllers;
        private readonly List<IExecute> _executeControllers;
        private readonly List<ILateExecute> _lateControllers;
        private readonly List<ICleanup> _cleanupControllers;

        internal Controllers()
        {
            _initializeControllers = new List<IInitialization>();
            _executeControllers = new List<IExecute>();
            _lateControllers = new List<ILateExecute>();
            _cleanupControllers = new List<ICleanup>();
        }

        internal Controllers Add(IController controller)
        {
            if (controller is IInitialization initializeController)
            {
                _initializeControllers.Add(initializeController);
            }

            if (controller is IExecute executeController)
            {
                _executeControllers.Add(executeController);
            }
            if (controller is ILateExecute lateControllers)
            {
                _lateControllers.Add(lateControllers);
            }
            if (controller is ICleanup cleanupControllers)
            {
                _cleanupControllers.Add(cleanupControllers);
            }

            return this;
        }

        public void Initialization()
        {
            for (int index = 0; index < _initializeControllers.Count; ++index)
            {
                _initializeControllers[index].Initialization();
            }
        }
        public void Execute(float deltaTime)
        {
            for (int index = 0; index < _executeControllers.Count; ++index)
            {
                _executeControllers[index].Execute(deltaTime);
            }
        }
        public void LateExecute(float deltaTime)
        {
            for (int index = 0; index < _lateControllers.Count; ++index)
            {
                _lateControllers[index].LateExecute(deltaTime);
            }
        }
        public void Cleanup()
        {
            for (int index = 0; index < _cleanupControllers.Count; ++index)
            {
                _cleanupControllers[index].Cleanup();
            }
        }

    }
}