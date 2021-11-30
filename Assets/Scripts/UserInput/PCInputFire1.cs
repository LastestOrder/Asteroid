using System;
using UnityEngine;

namespace Asteroid
{
    public sealed class PCInputFire1 : IUserInputProxy
    {
        public event Action<float> AxisOnChange = delegate(float f) {  };

        public void GetAxis()
        {
            AxisOnChange.Invoke(Input.GetAxis(AxisManagers.FIRE1));
        }
    }
}