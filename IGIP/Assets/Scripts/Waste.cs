using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class Waste : MonoBehaviour
{
    public WasteData wasteData;
    public float curSpeed;
    public Vector2 moveDir;

    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        curSpeed = Random.Range(wasteData.minSpeed, wasteData.maxSpeed);
    }

    private void Update()
    {
        transform.Translate(moveDir * (curSpeed * Time.deltaTime));
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Spear"))
        {
            audioSource.PlayOneShot(wasteData.clip);
            Destroy(gameObject);
            GameManager.instance.GetScore(wasteData.score);
            
        }
    }

    private void OnBecameInvisible()
    {
        Destroy(this);
    }
}