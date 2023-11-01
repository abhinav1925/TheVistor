using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


public class GoingUp : XRGrabInteractable
{
    public Transform xrrig;
    public Transform ladder;
    public Transform ladder2;
    Transform currentLocation1;
    Transform currentLocation2;

    //public GameObject button;
    void Start()
    {
        currentLocation1 = ladder.transform;
        currentLocation2 = ladder2.transform;
         
    }

    // Update is called once per frame
    void Update()
    {
        ladder.transform.position = currentLocation1.transform.position;
        ladder.transform.rotation = currentLocation1.transform.rotation;
    }



    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        base.OnSelectEntered(args);
        ladder.transform.position = currentLocation1.transform.position;
        ladder.transform.rotation = currentLocation1.transform.rotation;
     

    }



    protected override void OnHoverEntered(HoverEnterEventArgs args)
    {
        base.OnHoverEntered(args);
        xrrig.position = new Vector3(-1.537f, 9.237f, -8.1f);
        xrrig.GetComponent<ActionBasedContinuousMoveProvider>().enabled = false;
        ladder.GetComponent<Outline>().enabled = true;
        ladder2.GetComponent<Outline>().enabled = true;

    }
}
