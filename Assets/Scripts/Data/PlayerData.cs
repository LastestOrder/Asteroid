using UnityEngine;

namespace Asteroid
{
    [CreateAssetMenu(fileName = "UnitSettings", menuName = "Data/Unit/UnitSettings")]
    public sealed class PlayerData: ScriptableObject, IUnit, IDamage
    {
        public Sprite Sprite;
        [SerializeField] private string _name;
        [SerializeField, Range(0, 100)] private float _speed;
        [SerializeField, Range(0, 100)] private float _rotationSpeed;
        [SerializeField] private float _gravity;
        [SerializeField, Range(0, 100)] private float _damage;
        [SerializeField, Range(0, 100)] private float _attackSpeed;
        [SerializeField] private Vector2Int _position;
     

        public float Speed => _speed;
        public float Gravity => _gravity;
        public float RotationSpeed => _rotationSpeed;
        public float Damage => _damage;
        public float AttackSpeed => _attackSpeed;

        public Vector2 Postion => _position;

        public string Name => _name;
    }
}