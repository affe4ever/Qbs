using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestDoor : MonoBehaviour
{
  
    private GameManager gm;
    public bool open;
    public int pressed;
    public int amount;
    public bool canGoTrough;
    public AudioSource openSound;
    public AudioSource closesound;
    public Vector3 doorVector;


    // Start is called before the first frame update
    void Start()
    {
        gm = GameManager.instance;
        canGoTrough = false;
        if (transform.rotation.eulerAngles.y > -45 && transform.rotation.eulerAngles.y < 45)
        {
            doorVector = new Vector3(0, 0, -1.6f);
        }
        else if (transform.rotation.eulerAngles.y > 45 && transform.rotation.eulerAngles.y < 135)
        {
            doorVector = new Vector3(-1.6f, 0, 0);
        }
        else if (transform.rotation.eulerAngles.y > 135 && transform.rotation.eulerAngles.y < 225)
        {
            doorVector = new Vector3(0, 0, 1.6f);
        }
        else if (transform.rotation.eulerAngles.y > 225 && transform.rotation.eulerAngles.y < 315)
        {
            doorVector = new Vector3(1.6f, 0, 0);
        }
        if (open){
        OpenDoor();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        if (!open && amount == pressed)
        {
            OpenDoor();            
        }
        else if (open && amount != pressed)
        {
            CloseDoor();
        }

        if (canGoTrough && open)
        {
            gm.NextLevel();
        }

    }

    // funkar inte just nu
 

    private void OpenDoor()
    {
        openSound.Play();
        open = true;
        this.gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).GetComponent<Light>().color = Color.green;
        this.gameObject.transform.GetChild(1).position += doorVector;
        this.gameObject.transform.GetChild(2).position -= doorVector;
    }

    private void CloseDoor()
    {
        closesound.Play();
        open = false;
        this.gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).GetComponent<Light>().color = Color.red;
        this.gameObject.transform.GetChild(1).position -= doorVector;
        this.gameObject.transform.GetChild(2).position += doorVector;
    }

}
