using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


public class GoingDown : XRGrabInteractable
{
    public Transform xrrig;
    public Transform ladder;
    public Transform ladder2;
    Transform currentLocation1;
    void Start()
    {
        currentLocation1 = ladder2.transform;
    }

    // Update is called once per frame
    void Update()
    {
        ladder2.transform.position = currentLocation1.transform.position;
        ladder2.transform.rotation = currentLocation1.transform.rotation;
    }





    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        base.OnSelectEntered(args);
        
    
    }

 

    protected override void OnHoverEntered(HoverEnterEventArgs args)
    {
        base.OnHoverEntered(args);

        xrrig.position = new Vector3(-3.008f, 3.877f, -9.622f);
        xrrig.GetComponent<ActionBasedContinuousMoveProvider>().enabled = true;
        ladder.GetComponent<Outline>().enabled = false;
        ladder2.GetComponent<Outline>().enabled = false;

    }
}
