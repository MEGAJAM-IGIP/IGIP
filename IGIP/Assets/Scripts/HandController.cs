using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandController : MonoBehaviour
{
    private float angle;
    private Vector2 mouse;
    
    public GameObject spear;

    private float curTime;
    private float fireRate = 1f;
    
    void Start()
    {
        
    }
    
    void Update()
    {
        mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        angle = Mathf.Atan2(mouse.y, mouse.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, angle + 90);
        
        curTime += Time.deltaTime;
        if (Input.GetMouseButtonDown(0) && curTime > fireRate)
        {
            Shoot();
            curTime = 0;
        }
    }
    
    public void Shoot()
    {
        Instantiate(spear, transform.position, transform.rotation);
    }
}
