using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbductionOutro : MonoBehaviour
{
    public float smooth;

    private GameObject audioGO;

    public GameObject trigger;
    // Start is called before the first frame update
    void Start()
    {
        audioGO = GameObject.Find("Hoversound");
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > 20)
        {
            transform.Translate(Vector3.down * smooth * Time.deltaTime, Space.World);
        }
        else
        {
            trigger.SetActive(true);
            audioGO.SetActive(false);
        }
        
    }
}
