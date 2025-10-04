using UnityEngine;

public class CoinCollect : MonoBehaviour
{
    [SerializeField]
    private int coinType;

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
    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Player") {
            tracker.SendMessage("AddCoin", coinType);
            Destroy(gameObject);
        }
    }
}
