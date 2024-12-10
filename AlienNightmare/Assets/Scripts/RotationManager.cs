using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class RotationManager : MonoBehaviour
{
    private bool canRotate;
    [Header("Cameras")]
    public CinemachineVirtualCamera Nathan01Cam;
    public CinemachineVirtualCamera Stephen02Cam;
    public CinemachineVirtualCamera DMV03Cam;
    public CinemachineVirtualCamera Don04Cam;
    public CinemachineVirtualCamera Flork05Cam;
    public CinemachineVirtualCamera Kermit06Cam;
    
    [Header("States")]
    public BluntState currentState;
    public enum BluntState
    {
        Nathan,
        Stephen,
        DMV,
        DonQuixote,
        Flork,
        Kermit,
        MAXIMUM
    }
    // Start is called before the first frame update
    void Start()
    {
        currentState = BluntState.Nathan;
    }

    // Update is called once per frame
    void Update()
    {
        RotateCamera();
    }

    private void RotateCamera()
    {
        //State Changes
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            currentState++;
            canRotate = false;

            if (currentState >= BluntState.MAXIMUM)
            {
                currentState = 0;
            }
        }
        
        
        //State Conditions
        if (currentState == BluntState.Nathan)
        {
            Nathan01Cam.Priority = 2;
            Stephen02Cam.Priority = 1;
            DMV03Cam.Priority = 1;
            Don04Cam.Priority = 1;
            Flork05Cam.Priority = 1;
            Kermit06Cam.Priority = 1;
        }
        
        if (currentState == BluntState.Stephen)
        {
            Nathan01Cam.Priority = 1;
            Stephen02Cam.Priority = 2;
            DMV03Cam.Priority = 1;
            Don04Cam.Priority = 1;
            Flork05Cam.Priority = 1;
            Kermit06Cam.Priority = 1;
        }
        if (currentState == BluntState.DMV)
        {
            Nathan01Cam.Priority = 1;
            Stephen02Cam.Priority = 1;
            DMV03Cam.Priority = 2;
            Don04Cam.Priority = 1;
            Flork05Cam.Priority = 1;
            Kermit06Cam.Priority = 1;
        }
        if (currentState == BluntState.DonQuixote)
        {
            Nathan01Cam.Priority = 1;
            Stephen02Cam.Priority = 1;
            DMV03Cam.Priority = 1;
            Don04Cam.Priority =2;
            Flork05Cam.Priority = 1;
            Kermit06Cam.Priority = 1;
        }
        if (currentState == BluntState.Flork)
        {
            Nathan01Cam.Priority = 1;
            Stephen02Cam.Priority = 1;
            DMV03Cam.Priority = 1;
            Don04Cam.Priority = 1;
            Flork05Cam.Priority = 2;
            Kermit06Cam.Priority = 1;
        }
        if (currentState == BluntState.Kermit)
        {
            Nathan01Cam.Priority = 1;
            Stephen02Cam.Priority = 1;
            DMV03Cam.Priority = 1;
            Don04Cam.Priority = 1;
            Flork05Cam.Priority = 1;
            Kermit06Cam.Priority = 2;
        }
    }

    public void EnableRotation()
    {
        canRotate = true;
    }
}
