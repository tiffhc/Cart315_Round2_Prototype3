using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; 

public class Vegetable : MonoBehaviour
{
    private bool f_pressed;
    private bool e_pressed;

    public float speed = 1000f; 
    //public GameObject vege; 
    public Transform p; //player 

    private NavMeshAgent temp;

    private float time = 5f; 
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        f_pressed = Input.GetKeyDown("f");
       
        /*
        e_pressed = Input.GetKeyDown("e"); 

        if (e_pressed)
        {
            Debug.Log("Pressed e");
            this.gameObject.SetActive(true);
            //transform.position = Vector3.MoveTowards(transform.position, p.position, speed * Time.deltaTime); 
            //Instantiate(vege, p.position, Quaternion.identity); 
        }
        */

    }

   

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Found player by vegetable"); 
            if(f_pressed)
            {
                this.gameObject.SetActive(false); 
            }
        }

        if(other.gameObject.CompareTag("AI"))
        {
            Debug.Log("AI ennemy detected");
            temp = other.gameObject.GetComponent<NavMeshAgent>();

            temp.isStopped = true;

            StartCoroutine(countDown());

            Debug.Log("back into here");

            temp.isStopped = false; 
            
            /*
            temp.speed = 0;
            temp.angularSpeed = 0;
            temp.acceleration = 0; 
            */ 
        }
    }
    
    IEnumerator countDown()
    {
        Debug.Log("Inside countdown"); 

        /*
        while(time > 0)
        {
            time -= Time.deltaTime;
            Debug.Log(time); 
        }
        */ 
        yield return new WaitForSeconds(time);
       
    }

    
}
