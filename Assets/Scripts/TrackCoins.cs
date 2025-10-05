using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrackCoins : MonoBehaviour
{
    private int[] coinCounts;
    private static int[] savedCoins;
    
    [SerializeField] private TMP_Text coinText; // drag CoinText here
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        coinCounts = new int[3];
        if (savedCoins == null) {
            savedCoins = new int[3];
        }
        UpdateUI();
    }
    void AddCoin(int type) {
        coinCounts[type - 1]++;
        Debug.Log($"Collected coin type {type}. Count: {coinCounts[type - 1]}");
        UpdateUI();
    }
    private void UpdateUI()
    {
        coinText.text = $"Coin 1: {coinCounts[0]}, Coin 2: {coinCounts[1]}, Coin 3: {coinCounts[2]}";
    }
    void UseCoins(int ones, int twos, int threes) {
        coinCounts[0] -= ones;
        coinCounts[1] -= twos;
        coinCounts[2] -= threes;
    }
    void FinishLevel(int[] reqs) {
        if (coinCounts[0] >= reqs[0] && coinCounts[1] >= reqs[1] && coinCounts[2] >= reqs[2]) {
            UseCoins(reqs[0], reqs[1], reqs[2]);
            savedCoins[0] += coinCounts[0];
            savedCoins[1] += coinCounts[1];
            savedCoins[2] += coinCounts[2];
        }
    }
}
