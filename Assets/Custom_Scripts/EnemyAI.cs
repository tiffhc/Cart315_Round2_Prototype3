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
        Debug.Log("Ai killed player");
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(other.gameObject);
            SceneManager.LoadScene("GameOver_Lose", LoadSceneMode.Single);
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
