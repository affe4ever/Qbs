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

    public event UnityAction<int> onDoorTriggerEnter;
    public void DoorTriggerEnter(int id)
    {
        if (onDoorTriggerEnter != null)
        {
            onDoorTriggerEnter(id);
        }
    }
}
