using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavigationController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GoToMainMenu(){
     Time.timeScale = 1f; // Resume time
      Application.LoadLevel(0);
    }
    public void GoToLvl1(){
     
      Application.LoadLevel(1);
    }
    public void QuitGame(){
     Application.Quit();
    }
}
