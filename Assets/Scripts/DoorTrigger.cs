using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public int ones, twos, threes; //door open requirements

    private GameObject tracker;
    private Animator anim;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        tracker = GameObject.Find("Game Manager");
        anim = transform.parent.gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerStay2D(Collider2D other) {
        if (other.gameObject.tag == "Player") {
            if (Input.GetKey("e")) {
                if (tracker.GetComponent<TrackCoins>().CanUseCoins(ones, twos, threes)) {
                    tracker.SendMessage("UseCoins", new int[] {ones, twos, threes});
                    anim.SetTrigger("Door Opened");
                    RemoveDoor();
                }
            }
        }
    }
    void RemoveDoor() {
        Destroy(transform.parent.gameObject, 0.9f);
    }
}
