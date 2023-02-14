using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonController : MonoBehaviour
{
    public int id;

    void Start()
    {
        GameEvents.current.onButtonTriggerEnter += OnButtonPress;
        GameEvents.current.onButtonTriggerExit += OnButtonExit;
    }

    private void OnButtonPress(int id)
    {
        if (id == this.id)
        {
            Debug.Log("button " + id + " pressed");
        }
    }

    private void OnButtonExit(int id)
    {
        if (id == this.id)
        {
            Debug.Log("button " + id + " unpressed");
        }
    }

    private void OnDestroy()
    {
        GameEvents.current.onButtonTriggerEnter -= OnButtonPress;
        GameEvents.current.onButtonTriggerExit -= OnButtonPress;
    }
}
