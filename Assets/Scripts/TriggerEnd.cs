using UnityEngine;

public class TriggerEnd : MonoBehaviour
{
    private GameObject tracker;

    public int[] requirements;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        tracker = GameObject.Find("irs");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Player") {
            tracker.SendMessage("FinishLevel", requirements);
        }
    }
}
