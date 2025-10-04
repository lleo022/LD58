using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    Rigidbody2D body;

    public float speed = 7.0f; //player speed multiplier
    public float jumpSpeed = 11.5f; //jump speed

    // buffs (if we add them)
    private float speedBuff = 1.0f;
    private float jumpBuff = 1.0f;

    private bool canJump; //jump
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        canJump = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 velocity = body.linearVelocity;
        velocity.x = Input.GetAxisRaw("Horizontal") * speed * speedBuff;

        if (Input.GetKey("space") && canJump)
        {
            velocity.y = jumpSpeed * jumpBuff;
        }

        body.linearVelocity = velocity;
    }
    void EnableJump() {
        canJump = true;
    }
    void DisableJump() {
        canJump = false;
    }
}
