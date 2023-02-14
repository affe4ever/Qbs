using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible_pickup : MonoBehaviour
{
    public GameObject character;
    public GameObject collectible;
    private Collider characterCollider;
    private Collider collectibleCollider;
    private GameManager gm = GameManager.instance;

    void Start()
    {
        //Check that the first GameObject exists in the Inspector and fetch the Collider
        if (character != null)
            characterCollider = character.GetComponent<Collider>();

        //Check that the second GameObject exists in the Inspector and fetch the Collider
        if (collectible != null)
            collectibleCollider = collectible.GetComponent<Collider>();
    }

    void Update()
    {
        //If the first GameObject's Bounds enters the second GameObject's Bounds, output the message
        if (characterCollider.bounds.Intersects(collectibleCollider.bounds))
        {
            gm.FoundCollectable();
            Destroy(collectible);
            Debug.Log("Bounds intersecting");
        }
    }
}
