using UnityEngine;
using UnityEngine.SceneManagement;

public class MovePlayer : MonoBehaviour
{
    Rigidbody2D body;

    public float speed = 7.0f; //player speed multiplier
    public float jumpSpeed = 12f; //jump speed

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
        if (transform.position.y < -12.0f) {
            Reset();
        }
        Vector2 velocity = body.linearVelocity;
        velocity.x = Input.GetAxisRaw("Horizontal") * speed * speedBuff;

        if (Input.GetKey("space") && canJump)
        {
            velocity.y = jumpSpeed * jumpBuff;
        }

        body.linearVelocity = velocity;

        if (Input.GetKeyDown("p")) {
            Reset();
        }

        if (Input.GetKeyDown("escape")) {
            SceneManager.LoadScene(0);
        }

    }
    void EnableJump() {
        canJump = true;
    }
    void DisableJump() {
        canJump = false;
    }
    void Reset() {
        SceneManager.LoadScene("Intro1");
    }
}
