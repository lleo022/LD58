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
        UpdateUI();
    }
    private void UpdateUI()
    {
        coinText.text = $"      :{coinCounts[0]}      :{coinCounts[1]}      :{coinCounts[2]}";
    }
    public bool CanUseCoins(int ones, int twos, int threes) {
        return coinCounts[0] >= ones && coinCounts[1] >= twos && coinCounts[2] >= threes;
    }
    void UseCoins(int[] reqs) {
        coinCounts[0] -= reqs[0];
        coinCounts[1] -= reqs[1];
        coinCounts[2] -= reqs[2];
        UpdateUI();
    }
    void FinishLevel() {
        savedCoins[0] += coinCounts[0];
        savedCoins[1] += coinCounts[1];
        savedCoins[2] += coinCounts[2];
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
