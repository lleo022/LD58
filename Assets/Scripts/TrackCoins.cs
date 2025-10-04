using UnityEngine;

public class TrackCoins : MonoBehaviour
{
    private int[] coinCounts;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        coinCounts = new int[3];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void AddCoin(int type) {
        coinCounts[type - 1]++;
    }
}
