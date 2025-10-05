using UnityEngine;

public class DetectJump : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other) {
        SendMessageUpwards("EnableJump");
    }
    void OnTriggerExit2D(Collider2D other) {
        SendMessageUpwards("DisableJump");
    }

}
