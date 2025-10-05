using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public int ones, twos, threes;
    private GameObject tracker;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        tracker = GameObject.Find("irs");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerStay2D(Collider2D other) {
        if (other.gameObject.tag == "Player") {
            if (Input.GetKeyDown("e")) {
                
            }
        }
    }
}
