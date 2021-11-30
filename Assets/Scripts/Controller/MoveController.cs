using Unity.Mathematics;
using UnityEngine;

namespace Asteroid
{
    public sealed class MoveController : IExecute, ICleanup
    {
        //private readonly Transform _unit;
        private readonly Rigidbody2D _unit;
        private readonly IUnit _unitData;
        private float _horizontal;
        private float _vertical;
        private float _fire1;
        private Vector2 _move;
        private Quaternion _rotation;
        private IUserInputProxy _horizontalInputProxy;
        private IUserInputProxy _verticalInputProxy;
        private IUserInputProxy _fire1InputProxy;

        public MoveController(
            (IUserInputProxy inputHorizontal, IUserInputProxy inputVertical, IUserInputProxy inputFire1) input,
            GameObject unit, IUnit unitData)
        {
            _unit = unit.GetComponent<Rigidbody2D>();
            _unitData = unitData;
            _horizontalInputProxy = input.inputHorizontal;
            _verticalInputProxy = input.inputVertical;
            _fire1InputProxy = input.inputFire1;
            _horizontalInputProxy.AxisOnChange += HorizontalOnAxisOnChange;
            _verticalInputProxy.AxisOnChange += VerticalOnAxisOnChange;
            _fire1InputProxy.AxisOnChange += Fire1OnAxisOnChange;
        }

        private void VerticalOnAxisOnChange(float value)
        {
            _vertical = value;
        }

        private void HorizontalOnAxisOnChange(float value)
        {
            _horizontal = value;
        }

        private void Fire1OnAxisOnChange(float value)
        {
            _fire1 = value;
        }

        public void Execute(float deltaTime)
        {
            var speed = deltaTime * _unitData.Speed;
            var rotationSpeed = deltaTime * _unitData.RotationSpeed;

            _move.Set(0.0f, _vertical * speed);
            _unit.rotation -= _horizontal * rotationSpeed;
            _unit.transform.Translate(_move);

            //_unit.MovePosition(_unit.position+_move);
            //_rotation = Quaternion.Euler(0.0f, 0.0f, -_horizontal * rotationSpeed);
            //_unit.Translate(_move);
            //_unit.
            //_rotation = quaternion.Euler(0.0f, 0.0f, -_horizontal * rotationSpeed);
            // _unit.localRotation *= _rotation;
            //_rotation.Set(0.0f,0.0f,_horizontal*rotationSpeed,1);
            //_unit.transform()
            //_unit.localPosition += _move;
            //_rotation = Quaternion.Euler(0.0f,0.0f, _horizontal*rotationSpeed);
            //_unit.rotation = Quaternion.Euler(0.0f,0.0f, _horizontal*rotationSpeed);
        }

        public void Cleanup()
        {
            _horizontalInputProxy.AxisOnChange -= HorizontalOnAxisOnChange;
            _verticalInputProxy.AxisOnChange -= VerticalOnAxisOnChange;
            _fire1InputProxy.AxisOnChange -= Fire1OnAxisOnChange;
        }

        public void Execute(float deltaTime, object transform)
        {
            throw new System.NotImplementedException();
        }
    }
}