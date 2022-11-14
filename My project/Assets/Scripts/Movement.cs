using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private int speed;
    [SerializeField] private int jumpForce;
    [SerializeField] private bool grounded;
    [SerializeField] private StateManager stateManager;
    [SerializeField] private MusicManager musicManager;

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) || Input.GetKeyDown(KeyCode.Space))
        {
            if (grounded)
            {
                Jump();
            }
        }
        //if (Input.touchCount > 0)
        //{
        //    if (grounded)
        //    {
        //        Jump();
        //    }
        //}
    }

    private void FixedUpdate()
    {
        if (stateManager.state == "Playing")
            rb.velocity = new Vector2(speed, rb.velocity.y);
        else
        {
            rb.velocity = Vector2.zero;
        }
    }

    public void ResetGravity(int x)
    {
        rb.gravityScale = x;
    }

    private void Jump()
    {
        musicManager.PlayJump();
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            grounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            grounded = false;
        }
    }
}
