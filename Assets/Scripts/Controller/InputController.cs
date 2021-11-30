﻿

namespace Asteroid
{
    public sealed class InputController: IExecute
    {
        private readonly IUserInputProxy _horizontal;
        private readonly IUserInputProxy _vertical;
        private readonly IUserInputProxy _fire1;

        public InputController(
            (IUserInputProxy inputHorizontal, IUserInputProxy inputVertical, IUserInputProxy inputFire1) input)
        {
            _horizontal = input.inputHorizontal;
            _vertical = input.inputVertical;
            _fire1 = input.inputFire1;
        }

        public void Execute(float deltaTime)
        {
            _horizontal.GetAxis();
            _vertical.GetAxis();
            _fire1.GetAxis();
        }
    }
}