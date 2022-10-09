using System;
using Scriptables;
using UnityEngine;

public class Life : MonoBehaviour
{
    [SerializeField] private LifeData lifeData;
    private Sprite curSprite;
    public int curHealth;
    public Vector2 moveDir;
    public void Start()
    {
        curSprite = lifeData.liveSprite;
        curHealth = lifeData.health;
    }

    public void Die()
    {
        curSprite = lifeData.deadSprite;
        Destroy(gameObject, 3f);
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
        GameManager.Instance.GetScore(lifeData.score);
    }
}