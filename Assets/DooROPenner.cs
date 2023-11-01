using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


public class DooROPenner : XRGrabInteractable
{
    public Transform door;
    public GameObject k;
    public bool dooropened = false;
    key key;
    Animator animator;
    //public bool gotKey = false;
    // public GameObject button;
    // Start is called before the first frame update
    void Start()
    {
        animator = door.GetComponent<Animator>();
        key = FindObjectOfType<key>();
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void KeyDie()
    {
        //StartCoroutine("Killkey");
        // gotKey = true;
        // button.SetActive(true);
        if (key.gotKey)
        {
            door.GetComponent<Outline>().enabled = false;
            animator.Play("OpenDoor");
            dooropened = true;
            Destroy(k);
        }

        

      


    }



    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        base.OnSelectEntered(args);

        KeyDie();
    }
}
