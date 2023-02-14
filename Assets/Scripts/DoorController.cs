using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class DoorController : MonoBehaviour
{
    public int id;
    public bool isDoorOpen = false;

    void Start()
    {
        GameEvents.current.onDoorTriggerEnter += OnRoomExit;
        GameEvents.current.onButtonTriggerEnter += OnDoorOpen;
        GameEvents.current.onButtonTriggerExit += OnDoorClose;
    }

    private void OnRoomExit(int id)
    {
        if (id == this.id && isDoorOpen){
            Debug.Log("broder du är fri!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    private void OnDoorOpen(int id)
    {
        if (id == this.id)
        {
            Debug.Log("door opens");
            this.gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).GetComponent<Light>().color = Color.green;
            this.gameObject.transform.GetChild(1).position += new Vector3(0, 0, 1.6f);
            this.gameObject.transform.GetChild(2).position -= new Vector3(0, 0, 1.6f);
            isDoorOpen= true;
        }
    }

    private void OnDoorClose(int id)
    {
        if (id == this.id) 
        { 
            Debug.Log("door closes");
            this.gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).GetComponent<Light>().color = Color.red;
            this.gameObject.transform.GetChild(1).position -= new Vector3(0, 0, 1.6f);
            this.gameObject.transform.GetChild(2).position += new Vector3(0, 0, 1.6f);
            isDoorOpen= false;
        }
    }

    private void OnDestroy() 
    {
        GameEvents.current.onDoorTriggerEnter -= OnRoomExit;
        GameEvents.current.onButtonTriggerEnter -= OnDoorOpen;
        GameEvents.current.onButtonTriggerExit -= OnDoorClose;
    }
}
