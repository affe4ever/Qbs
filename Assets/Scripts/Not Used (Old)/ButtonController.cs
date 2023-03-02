using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonController : MonoBehaviour
{
    public int id;
    private AudioSource sound;

    void Start()
    {
        
        GameEvents.current.onButtonTriggerEnter += OnButtonPress;
        GameEvents.current.onButtonTriggerExit += OnButtonExit;
        sound = GetComponent<AudioSource>();
    }

    private void OnButtonPress(int id)
    {
        if (id == this.id)
        {
            this.gameObject.transform.GetChild(0).position -= new Vector3(0, (float) 0.05, 0);
            //GetComponentInChildren<Transform>().position -= new Vector3(0, (float) 0.4, 0);
            Debug.Log("button " + id + " pressed");
            sound.Play();
            
        }
    }

    private void OnButtonExit(int id)
    {
        if (id == this.id)
        {
            this.gameObject.transform.GetChild(0).position += new Vector3(0, (float)0.05, 0);
            //GetComponentInChildren<Transform>().position += new Vector3(0, (float) 0.4, 0);
            Debug.Log("button " + id + " unpressed");
            sound.Play();
        }
    }

    private void OnDestroy()
    {
        GameEvents.current.onButtonTriggerEnter -= OnButtonPress;
        GameEvents.current.onButtonTriggerExit -= OnButtonPress;
    }
}
