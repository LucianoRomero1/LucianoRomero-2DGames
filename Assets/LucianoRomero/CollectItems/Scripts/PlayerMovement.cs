using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private Rigidbody2D rb2d;
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private Animator animator;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        var movementValue = Input.GetAxis("Horizontal");

        if (movementValue == 0f)
        {
            animator.SetBool("isRunning", false);
        }

        if (movementValue > 0f)
        {
            spriteRenderer.flipX = false;
            animator.SetBool("isRunning", true);
        }
        else if (movementValue < 0f)
        {
            spriteRenderer.flipX = true;
            animator.SetBool("isRunning", true);
        }

        rb2d.velocity = new Vector2(movementValue * 20, transform.position.y);
    }
}
