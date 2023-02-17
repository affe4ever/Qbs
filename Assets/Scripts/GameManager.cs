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

    private List<string> levels = new List<string>{
        "Level 0", "Level 1,0", "Level 1,2", "Level 1,3"
    };
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
        DontDestroyOnLoad(me);
        awake();
        isGameOver = false;
        collectedCollectables = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //for testing 
        if (Input.GetKeyDown(KeyCode.G)){
            OpenMainMenu();
        }
        if (Input.GetKeyDown(KeyCode.H)){
            OpenLevel(0);
        }
        if (Input.GetKeyDown(KeyCode.J)){
            Debug.Log("Collectables: " + collectedCollectables);
        }
        if (Input.GetKeyDown(KeyCode.K)){
            OpenPauseMenu();
        }


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
    private void End(){
        Application.Quit();
    }

    public void OpenLevel(int i){
        if (i >= 0 && i < levels.Count)
            SceneManager.LoadScene(levels[i]);
        else Debug.LogError("Game Manager: Scene Level index out of range");
    }

    public void NextLevel(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    //the one that starts because the holderOfGameManager is in that scene
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
        collectedCollectables++;
    }

}
