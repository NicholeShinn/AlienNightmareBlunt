using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneManager : MonoBehaviour
{
    private int _triggerEnterTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(2);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        _triggerEnterTime += 1;
        if (_triggerEnterTime < 2)
        {
            return;
        }

        UnityEngine.SceneManagement.SceneManager.LoadScene(2);
    }
}
