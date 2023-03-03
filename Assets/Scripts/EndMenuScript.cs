using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndMenuScript : MonoBehaviour
{
    private GameManager gm;

    // Start is required for the script to get the gm.
    void Start(){
        gm = GameManager.instance;
    }

    public void BackToMainMenu(){
        gm.OpenMainMenu();
    }
}
