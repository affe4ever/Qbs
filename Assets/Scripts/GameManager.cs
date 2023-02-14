using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private bool isGameOver;

//Singleton start
    private static GameManager _instance;
    public static GameManager instance{
        get{
            if (_instance == null) Debug.LogError("Game Manager instance is null");
            return _instance;
        }
    }
    private void awake(){
        _instance = this;
    }
//Singleton end
    
    // Start is called before the first frame update
    void Start()
    {
        awake();
        isGameOver = false;
        //scene to main menu (SceneManager)
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver && Input.GetKeyDown(KeyCode.R)){
            //SceneManager.LoadScene(SceneManager.GetActiveScene().BuildIndex);
        }
    }

    public void setIsGameOver (bool state){
        isGameOver = state;
    }
    public bool getIsGameOver(){
        return isGameOver;
    }
}
