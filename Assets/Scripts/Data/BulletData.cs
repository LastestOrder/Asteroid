using UnityEngine;

namespace Asteroid
{
    [CreateAssetMenu(menuName = "Data/Data",fileName = "BulletData")]
    public sealed class BulletData: ScriptableObject
    {
        [SerializeField] private Sprite Sprite;

        private readonly PlayerData PlayerData;

    }
}