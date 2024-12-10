using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.R))
       {
           UnityEngine.SceneManagement.SceneManager.LoadScene("AbductionIntro");
       }

       if (Input.GetKeyDown(KeyCode.F))
       {
           Screen.fullScreen = !Screen.fullScreen;
       }
    }
}
