using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTrigger : MonoBehaviour
{
    public GameObject CameraController;
    private SwitchCamera cam;
    public int id;
    public GameObject placement;

    // Start is called before the first frame update
    void Start()
    {
        cam = CameraController.GetComponent<SwitchCamera>();
    }

    // Update is called once per frame
    void Update()
    {
        //id = CameraController.GetComponent<SwitchCube>().active;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ActivePlayer")
        {
            cam.ChangeCamera(placement.transform.position);
        }    
    }

    

}
