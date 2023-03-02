using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject me;
    private static bool isGameOver;
    //try making collectables static to see if the number remains after changing scene
    private static int collectedCollectables;
    private int CollectablesInLevel;
    private int collectedCollectablesInLevel;

    private AudioSource music;

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
        music = gameObject.GetComponent<AudioSource>();
        DontDestroyOnLoad(me);
        awake();
        isGameOver = false;
        collectedCollectables = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)){
            ReloadLevel();
        }
        if (Input.GetKeyDown(KeyCode.G)){
            FoundCollectable();
        }
        //for testing 
        if (Input.GetKeyDown(KeyCode.J)){
            Debug.Log("Collectables: " + collectedCollectables + "  CollectablesInLevel: " + collectedCollectablesInLevel);
        }
        if (Input.GetKeyDown(KeyCode.K)){
            End();
        }
    }

    public void setIsGameOver (bool state){
        isGameOver = state;
    }
    public bool getIsGameOver(){
        return isGameOver;
    }
    public void End(){
        Application.Quit();
    }

    public void NextLevel(){
        collectedCollectables += collectedCollectablesInLevel;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        collectedCollectablesInLevel = 0;
    }
    public void ReloadLevel(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        collectedCollectablesInLevel = 0;
    }

    
    public void OpenMainMenu(){
        SceneManager.LoadScene("maine menu");
    }

    public void OpenPauseMenu(){
        SceneManager.LoadScene("Level 1,0");
    }

    public void OpenEndMenu(){
        SceneManager.LoadScene("end menu");
    }

    public void FoundCollectable(){
        collectedCollectablesInLevel++;
    }
    public void PlayMusic()
    {
        music.Play();
    }
}
