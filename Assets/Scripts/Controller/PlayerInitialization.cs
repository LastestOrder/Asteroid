using UnityEngine;

namespace Asteroid
{
    public sealed class PlayerInitialization: IInitialization
    {
        private readonly IPlayerFactory _playerFactory;
        private GameObject _player;

        public PlayerInitialization(IPlayerFactory playerFactory, Vector2 positionPlayer)
        {
            _playerFactory = playerFactory;
            _player = _playerFactory.CreatePlayer();
            _player.transform.position = positionPlayer;
        }

        public void Initialization()
        {
            
        }

        public GameObject GetPlayer()
        {
            return _player;
        }
    }
}