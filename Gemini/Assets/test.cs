using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public GameObject pauseMenu; 
    // Start is called before the first frame update
    void Start()
    {
         
        pauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKeyDown(KeyCode.Escape))
        {
             pauseMenu.SetActive(true); 
            
        }
    }
     
}
