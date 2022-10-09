using System;
using Scriptables;
using UnityEngine;

public class Life : MonoBehaviour
{
    [SerializeField] private LifeData lifeData;
    private Sprite curSprite;
    public int curHealth;
    public void Start()
    {
        curSprite = lifeData.liveSprite;
        curHealth = lifeData.health;
    }

    public void Die()
    {
        curSprite = lifeData.deadSprite;
        // 물고기 위로 뜨는 거 구현
    }

    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Waste"))
        {
            curHealth--;
            if (curHealth == 0)
            {
                Die();
            }
        }
    }

    public void OnBecameInvisible()
    {
        Destroy(this);
    }
}