using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingManager : MonoBehaviour
{
    [Header("Sound")] 
    public AudioSource nightmare;

    public AudioSource eject;

    [Header("Characters")] 
    public GameObject Kermit;

    public GameObject StephenKing;

    [Header("EndTriggers")] 
    
    public GameObject endAnimKermit;

    public GameObject endKermitEject;

    [Header("Buttons")] 
    public GameObject kermitNButton;
    public GameObject kermitSButton;

    public void KermitRelease()
    {
        nightmare.Play();
        endAnimKermit.SetActive(true);
        kermitNButton.SetActive(false);
        kermitSButton.SetActive(false);
    }

    public void KermitEject()
    {
       eject.Play();
       endKermitEject.SetActive(true);
       Kermit.SetActive(false);
       kermitNButton.SetActive(false);
       kermitSButton.SetActive(false);
    }
}
