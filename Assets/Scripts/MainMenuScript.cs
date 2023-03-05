using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuScript : MonoBehaviour
{
    private GameManager gm;

    // Start is required for the script to get the gm.
    void Start(){
        gm = GameManager.instance;
    }

    public void PlayGame(){
        
        gm.NextLevel();
    }
    
    public void QuitGame(){
        gm.End();
    }
}
