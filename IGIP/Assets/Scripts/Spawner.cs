using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Waste[] wastes;
    public Vector2 moveDir;

    private BoxCollider2D col;
    void Start()
    {
        col = GetComponent<BoxCollider2D>();
        StartCoroutine(CreateWaste());
    }

    void Update()
    {
        
    }

    public Vector2 ReturnRandomPos()
    {
        float rangeY = col.bounds.size.y;
        rangeY = Random.Range(-(rangeY / 2), (rangeY / 2));
        Vector2 spawnPos = new Vector2(transform.localPosition.x, transform.localPosition.y + rangeY);
        return spawnPos;
    }

    public IEnumerator CreateWaste()
    {
        float randWaitTime = Random.Range(1f, 3.5f);
        while (!GameManager.instance.isGameOver)
        {
            int randNum = Random.Range(0, wastes.Length);
            var waste = wastes[randNum];
            waste.moveDir = moveDir;
            Instantiate(waste, ReturnRandomPos(), transform.rotation).transform.SetParent(transform);
            yield return new WaitForSeconds(randWaitTime);
        }
    }
}
