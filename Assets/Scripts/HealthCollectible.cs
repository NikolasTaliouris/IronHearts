using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectible : MonoBehaviour
{
    [SerializeField] private int healthValue;
 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            //Debug.Log("it collides");
            collision.GetComponent<PlayerHealth>().AddHealth(healthValue);
            Destroy(gameObject);
            Score.instance.AddScore();
        }
    }

}
