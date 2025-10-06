using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    [SerializeField] Slider _sliderVolume;

    private void Start()
    {
        if (!PlayerPrefs.HasKey("MusicLevel"))
        {
            PlayerPrefs.SetFloat("MusicLevel", 1);
            LoadMusic();

        }
        else
        {
            LoadMusic();

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   public void ChangeVolume()
    {
        AudioListener.volume = _sliderVolume.value;
        SaveVolume();
    }
    void SaveVolume()
    {
        PlayerPrefs.SetFloat("MusicLevel", _sliderVolume.value);

    }
    void LoadMusic()
    {
       _sliderVolume.value = PlayerPrefs.GetFloat("MusicLevel");
    }
}
