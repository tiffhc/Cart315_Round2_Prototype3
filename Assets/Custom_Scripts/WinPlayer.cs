﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class WinPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Found treasure"); 
        if(other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("GameOver_Win", LoadSceneMode.Single); 
        }
    }
}
