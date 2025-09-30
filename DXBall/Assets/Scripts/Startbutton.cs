using UnityEngine;
using UnityEngine.SceneManagement;

public class Startbutton : MonoBehaviour

{
    // This method will be called when the button is clicked
    public void OnStartButtonClick()
    {
        // Load the scene named "Level1"
        SceneManager.LoadScene("level 1");
        
        // Alternatively, if you know the build index:
        // SceneManager.LoadScene(1);
    }
}
