using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; 

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
}
