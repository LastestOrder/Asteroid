namespace Asteroid
{
    public interface ILateExecute: IController
    {
        void LateExecute(float deltaTime);
    }
}