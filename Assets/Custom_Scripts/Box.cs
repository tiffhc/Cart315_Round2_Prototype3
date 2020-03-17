using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    public GameObject inside; 
    private bool f_pressed; 
    // Start is called before the first frame update
    void Start()
    {
        //mute all the inner objects
        inside.SetActive(false); 
    }

    // Update is called once per frame
    void Update()
    {
        f_pressed = Input.GetKeyDown("f"); 
    }

    private void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Found box"); 

            if(f_pressed)
            {
                Destroy(collision.gameObject);

                //give the other object
                inside.SetActive(true); 

                
            }
        }
    }
}
