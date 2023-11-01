using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


public class Clock : XRGrabInteractable
{
    AudioSource asa;
    public  AudioClip click;
    void Start()
    {
        asa = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }




    protected override void OnHoverEntered(HoverEnterEventArgs args)
    {
        base.OnHoverEntered(args);
        asa.Stop();
        asa.clip = click;
        asa.loop = false;
        asa.Play();

    }
}