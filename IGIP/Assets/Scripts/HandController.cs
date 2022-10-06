using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandController : MonoBehaviour
{
    private float angle;
    private Vector2 mouse;
    
    public GameObject spear;
    
    void Start()
    {
        
    }
    
    void Update()
    {
        mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        angle = Mathf.Atan2(mouse.y, mouse.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, angle + 90);
        
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }
    
    public void Shoot()
    {
        Instantiate(spear, transform.position, transform.rotation);
    }
}
