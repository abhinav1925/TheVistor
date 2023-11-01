using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


public class GoUp : MonoBehaviour
{
    public GameObject button;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Goup()
    {
        transform.position = new Vector3(-1.537f, 9.237f, -8.1f);
        this.GetComponent<ActionBasedContinuousMoveProvider>().enabled = false;
        button.SetActive(true);

    }
    public void GoDown()
    {
        transform.position = new Vector3(-3.008f, 3.877f, -9.622f);
        this.GetComponent<ActionBasedContinuousMoveProvider>().enabled = true;
    }
}
