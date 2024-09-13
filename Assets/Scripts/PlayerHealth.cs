using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{

    [SerializeField] private int maxHealth = 100;
    [SerializeField] private int currentHealth;
    [SerializeField] private int enemyDamage;

    [SerializeField] private HealthBar healthbar;
    [SerializeField] private GameObject player;




    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthbar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void TakeDamage(int damage)
    {

        currentHealth -= damage;
        healthbar.setHealth(currentHealth);

        if(currentHealth <= 0)
        {
            Die();
            SceneManager.LoadScene("GameOverScreen");

        }

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.CompareTag("Enemy"))
        {
            TakeDamage(enemyDamage);
        }
    }


    void Die()
    {
        Debug.Log("Player died!");
        //GetComponent<Collider2D>().enabled = false;
        player.SetActive(false);
       // this.enabled = false;
        
    }


    public void AddHealth(int value)
    {
        currentHealth += value;
        healthbar.setHealth(currentHealth);
    }



}
