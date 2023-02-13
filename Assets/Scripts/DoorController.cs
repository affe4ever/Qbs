using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class DoorController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameEvents.current.onDoorTriggerEnter += OnRoomExit;
    }

    private void OnRoomExit()
    {
        Debug.Log("broder du är fri!");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    private void OnDestroy() {
        GameEvents.current.onDoorTriggerEnter -= OnRoomExit;
    }
}
