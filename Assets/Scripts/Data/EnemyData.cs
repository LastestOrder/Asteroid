using System.Collections.Generic;
using UnityEngine;

namespace Asteroid
{
    [CreateAssetMenu(fileName = "EnemySettings", menuName = "Data/Unit/EnemySettings")]
    public sealed class EnemyData: ScriptableObject, IDamage, IHealth
    {
        // [SerializeField] private EnemyProvider EnemyPrefab;
        //
        // [SerializeField] private List<EnemyInfo> _enemyInfos;
        public float Damage { get; }
        public float AttackSpeed { get; }
        public float Health { get; }
    }
}