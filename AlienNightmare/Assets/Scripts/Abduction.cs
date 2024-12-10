using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Abduction : MonoBehaviour
{
    public GameObject UFO;

    public GameObject UFOlight;

    public AudioSource hoverSource;
    public bool isabducted;
    public float smooth;

    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(abducted());
        isabducted = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isabducted)
        {
            transform.Translate(Vector3.up * smooth * Time.deltaTime, Space.World);
        }
    }

    public IEnumerator abducted()
    {
        yield return new WaitForSeconds(15f);
        UFO.SetActive(true);
        UFOlight.SetActive(true);
        hoverSource.Play();
        isabducted = true;
        yield return new WaitForSeconds(15f);
        UnityEngine.SceneManagement.SceneManager.LoadScene("RoundTableScene");
    }
}
