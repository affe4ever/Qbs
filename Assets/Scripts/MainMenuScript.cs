using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    private GameManager gm;

    // Start is required for the script to get the gm.
    void Start(){
        gm = GameManager.instance;
    }

    public void PlayGame(){
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        gm.OpenLevel(0);
    }
    
    public void QuitGame(){
        Application.Quit();
    }
}
