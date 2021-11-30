using UnityEngine;

namespace Asteroid
{
    public sealed class PlayerFactory : IPlayerFactory
    {
        private readonly PlayerData _playerData;

        public PlayerFactory(PlayerData playerData)
        {
            _playerData = playerData;
        }

        public GameObject CreatePlayer()
        {
            return new GameObject(_playerData.Name).AddRigidBody2D(_playerData.Gravity).AddSprite(_playerData.Sprite).
                AddCircleCollider2D().AddCircleCollider2D();
        }
    }
}