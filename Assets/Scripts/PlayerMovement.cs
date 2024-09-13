using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Animator animator;



    Vector2 movement;



    private void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y =  Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);

        if (movement.x > 0)
        {
            gameObject.transform.localScale = new Vector3(1, 1, 1);
        }
        else if (movement.x < 0)
        {
            gameObject.transform.localScale = new Vector3(-1, 1, 1);
        }


    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position +  movement * moveSpeed * Time.fixedDeltaTime);
    }

}
