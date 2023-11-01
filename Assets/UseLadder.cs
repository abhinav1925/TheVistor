using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class UseLadder : MonoBehaviour
{
    public Transform xrrig;
    public Transform ladder;
    public Transform ladder2;
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
        if(other.gameObject.tag == "ladder")
        {
            xrrig.position = new Vector3(-1.537f, 9.237f, -8.1f);
            xrrig.GetComponent<ActionBasedContinuousMoveProvider>().enabled = false;
            ladder.GetComponent<Outline>().enabled = true;
            ladder2.GetComponent<Outline>().enabled = true;

        }

        if(other.gameObject.tag == "ladder2")
        {
            xrrig.position = new Vector3(-3.008f, 3.877f, -9.622f);
            xrrig.GetComponent<ActionBasedContinuousMoveProvider>().enabled = true;
            ladder.GetComponent<Outline>().enabled = false;
            ladder2.GetComponent<Outline>().enabled = false;
        }

    }
}
