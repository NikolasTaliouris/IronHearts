using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int maxHealth = 100;
    [SerializeField] private int currentHealth;
    [SerializeField] private GameObject enemy;




    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void TakeDamage(int damage)
    {

        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            Die();
        }

    }



    void Die()
    {
        Debug.Log("Enemy died!");
        //GetComponent<Collider2D>().enabled = false;
        enemy.SetActive(false);
        // this.enabled = false;
        Score.instance.AddScore();

    }

}
