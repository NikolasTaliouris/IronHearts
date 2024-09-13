using UnityEngine;

public class CoinCollect : MonoBehaviour
{

    [SerializeField] private AudioSource coinSound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Coins"))
        {
            Destroy(collision.gameObject);
            coinSound.Play();
            Score.instance.AddScore();
        }
    }
}
