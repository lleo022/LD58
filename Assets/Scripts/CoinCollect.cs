using UnityEngine;

public class CoinCollect : MonoBehaviour
{
    [SerializeField] private int coinType;
    [SerializeField] private TrackCoins tracker; // drag in inspector

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
