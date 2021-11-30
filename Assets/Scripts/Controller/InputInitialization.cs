namespace Asteroid
{
    public class InputInitialization : IInitialization
    {
        private IUserInputProxy _pcInputHorizotal;
        private IUserInputProxy _pcInputVertical;
        private IUserInputProxy _pcInputFire1;

        public InputInitialization()
        {
            _pcInputHorizotal = new PCInputHorizontal();
            _pcInputVertical = new PCInputVertical();
            _pcInputFire1 = new PCInputFire1();
        }

        public void Initialization()
        {
            
        }

        public (IUserInputProxy inputHorizontal, IUserInputProxy inputVertical, IUserInputProxy inputFire1) GetInput()
        {
            (IUserInputProxy inputHorizontal, IUserInputProxy inputVertical, IUserInputProxy inputFire1) result = (
                _pcInputHorizotal, _pcInputVertical, _pcInputFire1);
            return result;
        }
    }
}