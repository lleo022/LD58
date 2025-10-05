using UnityEngine;

public class CoinCollect : MonoBehaviour
{
    [SerializeField] private int coinType;
    private GameObject tracker;

    void Start() {
        tracker = GameObject.Find("Game Manager");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log($"Collided with coin");
        if (other.CompareTag("Player"))
        {
            tracker.SendMessage("AddCoin",coinType);
            Destroy(gameObject);
        }
    }
}
