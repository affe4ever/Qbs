using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCube : MonoBehaviour
{

    public Transform focus;
    private SwitchCamera active;

    public GameObject cube1;

    public GameObject cube2;
    
    public GameObject cube3;


    // Start is called before the first frame update
    void Start()
    {
        active = gameObject.GetComponent<SwitchCamera>();

        if (cube2 == null)
        {
            cube2 = null;
        }
        else
        {
            cube2.GetComponent<Movemont>().cam = active.transform.position;
        }

        if (cube3 == null)
        {
            cube3 = null;
        }
         else
        {
            cube3.GetComponent<Movemont>().cam = active.transform.position;
        }
        
        Switch(cube1);
    }
    // Update is called once per frame
    void Update()
    {
        transform.LookAt(focus);

        if (Input.GetKey(KeyCode.Alpha1))
        {            
            if(cube1 != null)
            {               
                Switch(cube1); 
            }           
        }
        else if(Input.GetKey(KeyCode.Alpha2))
        {
            if(cube2 != null)
            {               
               Switch(cube2); 
            }           
        }
        else if(Input.GetKey(KeyCode.Alpha3))
        {
            if(cube3 != null)
            {
                
                Switch(cube3); 
            }    
        }
    }

    void Switch(GameObject cube)
    {
        if (cube == cube1)
        {
            focus = GameObject.Find(cube.name).transform;
            cube1.tag = ("ActivePlayer");
            active.ChangeCamera(cube1.GetComponent<Movemont>().cam);
            
        
            //sätter på scripts för active           
            MonoBehaviour[] scripts1 = cube1.GetComponents<MonoBehaviour>();
            foreach(MonoBehaviour script in scripts1)
            {
                script.enabled = true;
            }

            //stänger av dom andra
            if (cube2 != null)
            { 
                cube2.tag = ("Player");
                MonoBehaviour[] scripts2 = cube2.GetComponents<MonoBehaviour>();
                foreach(MonoBehaviour script in scripts2)
                {
                    script.enabled = false;
                }
            }

            if (cube3 != null)
            {
                cube3.tag = ("Player");
                MonoBehaviour[] scripts3 = cube3.GetComponents<MonoBehaviour>();
                foreach(MonoBehaviour script in scripts3)
                {
                    script.enabled = false;
                }
            }
            
        }
        else if (cube == cube2)
        {
            focus = GameObject.Find(cube.name).transform;
            cube1.tag = ("Player");
            cube2.tag = ("ActivePlayer");
            active.ChangeCamera(cube2.GetComponent<Movemont>().cam);
            


            //sätter på scripts för active           
            MonoBehaviour[] scripts2 = cube2.GetComponents<MonoBehaviour>();
            foreach(MonoBehaviour script in scripts2)
            {
                script.enabled = true;
            }


            //stänger av dom andra
            MonoBehaviour[] scripts1 = cube1.GetComponents<MonoBehaviour>();
            foreach(MonoBehaviour script in scripts1)
            {
                script.enabled = false;
            }

            if (cube3 != null)
            {
                cube3.tag = ("Player");
                MonoBehaviour[] scripts3 = cube3.GetComponents<MonoBehaviour>();
                foreach(MonoBehaviour script in scripts3)
                {
                    script.enabled = false;
                }
            }
            
        }
        else if (cube == cube3)
        {
            focus = GameObject.Find(cube.name).transform;
            cube1.tag = ("Player");
            cube2.tag = ("Player");
            cube3.tag = ("ActivePlayer");
            active.ChangeCamera(cube3.GetComponent<Movemont>().cam);


            //sätter på scripts för active
                       
            MonoBehaviour[] scripts3 = cube3.GetComponents<MonoBehaviour>();
            foreach(MonoBehaviour script in scripts3)
            {
                script.enabled = true;
            }


            //stänger av dom andra
            
            MonoBehaviour[] scripts1 = cube1.GetComponents<MonoBehaviour>();
            foreach(MonoBehaviour script in scripts1)
            {
                script.enabled = false;
            }

            
            MonoBehaviour[] scripts2 = cube2.GetComponents<MonoBehaviour>();
            foreach(MonoBehaviour script in scripts2)
            {
                script.enabled = false;
            }
        }
        
        
    }
}
