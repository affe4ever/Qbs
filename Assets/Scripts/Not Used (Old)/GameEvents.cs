using System;
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

    public event Action<int> onDoorTriggerEnter;
    public event Action<int> onButtonTriggerEnter;
    public event Action<int> onButtonTriggerExit;
    public void DoorTriggerEnter(int id)
    {
        if (onDoorTriggerEnter != null)
        {
            onDoorTriggerEnter(id);
        }
    }
    public void OpenDoor(int id)
    {

    }
    public void CloseDoor(int id)
    {

    }
    public void ButtonTriggerEnter(int id)
    {
        if (onButtonTriggerEnter != null)
        {
            onButtonTriggerEnter(id);
        }
    }
    public void ButtonTriggerExit(int id)
    {
        if (onButtonTriggerExit != null)
        {
            onButtonTriggerExit(id);
        }
    }
}
