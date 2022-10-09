using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spear : MonoBehaviour
{
    public float speed;
    void Start()
    {
        
    }
    
    void Update()
    {
        transform.Translate(Vector2.down * (speed * Time.deltaTime));
    }

    public void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }
}
