using TMPro;
using UnityEngine;

public class TrackCoins : MonoBehaviour
{
    private int[] coinCounts;
    [SerializeField] private TMP_Text coinText; // drag CoinText here

    void Start()
    {
        coinCounts = new int[3];
        UpdateUI();
    }
    public void AddCoin(int type)
    {
        coinCounts[type - 1]++;
        Debug.Log($"Collected coin type {type}. Count: {coinCounts[type - 1]}");
        UpdateUI();
    }
    private void UpdateUI()
    {
        coinText.text = $"Coin 1: {coinCounts[0]}, Coin 2: {coinCounts[1]}, Coin 3: {coinCounts[2]}";
    }
}
