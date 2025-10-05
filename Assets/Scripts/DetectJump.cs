using UnityEngine;

public class DetectJump : MonoBehaviour
{
    private int groundContacts = 0;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Ground"))
        {
            groundContacts++;
            SendMessageUpwards("EnableJump");
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Ground"))
        {
            groundContacts--;
            if (groundContacts <= 0)
            {
                SendMessageUpwards("DisableJump");
            }
        }
    }
}
