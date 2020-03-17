using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement; 

public class EnemyAI : MonoBehaviour
{
    public NavMeshAgent monster; 
    public GameObject destination; 
    // Start is called before the first frame update
    void Start()
    {
        monster = this.GetComponent<NavMeshAgent>(); 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //continously find them
        monster.SetDestination(destination.transform.position);
    }

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Detected something - AI");

        if (other.gameObject.CompareTag("Player"))
        {
            //Debug.Log("Ai killed player");
            SceneManager.LoadScene("GameOver_Lose", LoadSceneMode.Single);
        }

        if (other.gameObject.CompareTag("Vegetable"))
        {
            //Debug.Log("Found vege - stopping AI");

            monster.isStopped = true; 
            float count = 50000000f;
            if (count >= 0)
            {
                count -= Time.deltaTime;
            }
            else if (count < 0)
            {
                monster.isStopped = false; 
            }

        }


    }

    /* 
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("Ai killed player");
        if (other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("GameOver_Lose", LoadSceneMode.Single);
        }
    }
    */

}
