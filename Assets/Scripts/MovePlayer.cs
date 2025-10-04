using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    Rigidbody2D body;

    private float speed = 7.0f; //player speed multiplier
    private float jumpSpeed = 11.5f; //jump speed

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
        body.linearVelocityX = Input.GetAxisRaw("Horizontal") * speed;
        if (Input.GetKey("space")) {
            if (canJump) {
                body.linearVelocityY = jumpSpeed;
            }
        }
    }
    void EnableJump() {
        canJump = true;
    }
    void DisableJump() {
        canJump = false;
    }
}
