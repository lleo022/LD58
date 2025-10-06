using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleTransitions : MonoBehaviour
{
    void Start() {
        Destroy(GameObject.Find("SoundPlayer"));
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
    //Loads Scenes based on button pressed
   public void TransitiontoLVL1()
    {
        SceneManager.LoadScene("Intro1");
    }
    public void TransitiontoSettings()
    {
        SceneManager.LoadScene("Settings");
    }
    public void TransitiontoQuit()
    {
        Application.Quit();
    }
    public void TransitiontoMain()
    {
        SceneManager.LoadScene("Title Screen");
    }
    public void ResetScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Debug.Log("YES");
    }
}
