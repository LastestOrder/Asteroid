using System.Collections.Generic;
using System.Timers;
using UnityEditor;
using UnityEngine;

namespace Asteroid
{
    public sealed class BulletInitialization : IInitialization, IExecute
    {
        private readonly BulletPool _bulletPool;
        private List<Asteroid> _asteroids;
        private Rigidbody2D _rigidbody2D;
        private readonly PlayerData _playerData;
        private float _distance = 3f;
        private Transform _transform;
        private bool _shooting = true;
        private float _attackSpeed;

        public BulletInitialization(List<Asteroid> asteroids, Transform player, PlayerData playerData)
        {
            _asteroids = asteroids;
            _distance = playerData.AttackSpeed;
            _transform = player.transform;
        }

        public BulletData _bulletData;


        public void Initialization()
        {
        }

        public void Execute(float deltaTime)
        {
            Vector2 _rotation = new Vector2(_transform.rotation.x, _transform.rotation.y);
            RaycastHit2D hit2D = Physics2D.Raycast(_rigidbody2D.position, _rotation, _distance);
            if (hit2D)
            {
                if (_shooting)
                {
                    var asteroidHit2d = GetAstoroid(hit2D);
                    _shooting = false;
                    Timer(_attackSpeed);
                }
            }
        }

        private Asteroid GetAstoroid(RaycastHit2D hit2d)
        {
            Asteroid result = null;
            foreach (var asteroid in _asteroids)
            {
                if (asteroid.gameObject == hit2d)
                {
                    result = asteroid;
                }
            }

            return result;
        }

        private void Timer(float attackSpeed)
        {
            attackSpeed -= Time.deltaTime;
            if (attackSpeed < 0)
            {
                _shooting = true;
                return;
            }
        }
    }
}