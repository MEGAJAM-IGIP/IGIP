using UnityEngine;

namespace Scriptables
{
    [CreateAssetMenu(fileName = "new Life", menuName = "Life", order = 0)]
    public class LifeData : ScriptableObject
    {
        public Sprite liveSprite;
        public Sprite deadSprite;
        public AudioClip hitSound;
        public int health;
        public int score;
    }
}