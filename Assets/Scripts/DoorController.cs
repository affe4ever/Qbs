using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class DoorController : MonoBehaviour
{
    public int id;

    void Start()
    {
        GameEvents.current.onDoorTriggerEnter += OnRoomExit;
    }

    private void OnRoomExit(int id)
    {
        if (id == this.id){
            Debug.Log("broder du är fri!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    private void OnDestroy() 
    {
        GameEvents.current.onDoorTriggerEnter -= OnRoomExit;
    }
}
