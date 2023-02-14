using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible_pickup : MonoBehaviour
{
    public GameObject character;
    public GameObject collectible1;
    private Collider characterCollider;
    private Collider collectible1Collider;

    void Start()
    {
        //Check that the first GameObject exists in the Inspector and fetch the Collider
        if (character != null)
            characterCollider = character.GetComponent<Collider>();

        //Check that the second GameObject exists in the Inspector and fetch the Collider
        if (collectible1 != null)
            collectible1Collider = collectible1.GetComponent<Collider>();
    }

    void Update()
    {
        //If the first GameObject's Bounds enters the second GameObject's Bounds, output the message
        if (characterCollider.bounds.Intersects(collectible1Collider.bounds))
        {
            Destroy(collectible1);
            Debug.Log("Bounds intersecting");
        }
    }
}
