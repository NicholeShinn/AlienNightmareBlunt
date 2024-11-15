using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class RotationManager : MonoBehaviour
{
    [Header("Cameras")]
    public CinemachineVirtualCamera Kermit01Cam;
    public CinemachineVirtualCamera Kermit02Cam;
    public CinemachineVirtualCamera Kermit03Cam;
    public CinemachineVirtualCamera Kermit04Cam;
    
    [Header("States")]
    public BluntState currentState;
    public enum BluntState
    {
        Kermit01,
        Kermit02,
        Kermit03,
        Kermit04,
        MAXIMUM
    }
    // Start is called before the first frame update
    void Start()
    {
        currentState = BluntState.Kermit01;
    }

    // Update is called once per frame
    void Update()
    {
        //State Changes
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            currentState++;

            if (currentState >= BluntState.MAXIMUM)
            {
                currentState = 0;
            }
        }
        
        
        //State Conditions
        if (currentState == BluntState.Kermit01)
        {
            Kermit01Cam.Priority = 2;
            Kermit02Cam.Priority = 1;
            Kermit03Cam.Priority = 1;
            Kermit04Cam.Priority = 1;
        }
        
        if (currentState == BluntState.Kermit02)
        {
            Kermit01Cam.Priority = 1;
            Kermit02Cam.Priority = 2;
            Kermit03Cam.Priority = 1;
            Kermit04Cam.Priority = 1;
        }
        if (currentState == BluntState.Kermit03)
        {
            Kermit01Cam.Priority = 1;
            Kermit02Cam.Priority = 1;
            Kermit03Cam.Priority = 2;
            Kermit04Cam.Priority = 1;
        }
        if (currentState == BluntState.Kermit04)
        {
            Kermit01Cam.Priority = 1;
            Kermit02Cam.Priority = 1;
            Kermit03Cam.Priority = 1;
            Kermit04Cam.Priority = 2;
        }
    }
}
