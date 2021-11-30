using System;

namespace Asteroid
{
    public interface IEnemy: IMove
    {
        event Action<int> OnTriggerEnterChange;
    }
}