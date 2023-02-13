using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameEvents : MonoBehaviour
{
    public static GameEvents current;

    private void Awake()
    {
        current = this;
    }

    public event UnityAction onDoorTriggerEnter;
    public void DoorTriggerEnter()
    {
        if (onDoorTriggerEnter != null)
        {
            onDoorTriggerEnter();
        }
    }
}
