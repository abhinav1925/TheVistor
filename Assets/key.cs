using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


public class key : XRGrabInteractable
{
    public GameObject k;
    public bool gotKey = false;
    public Transform doorhandle;
    AudioSource ad;
    //public GameObject button;
    // Start is called before the first frame update
    void Start()
    {
        ad = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void KeyDie()
    {
        StartCoroutine(KillKey());
        
       
       

    }

    IEnumerator KillKey()
    {
        doorhandle.gameObject.SetActive(true);
        gotKey = true;
        ad.Play();
        yield return new WaitForSeconds(1f);
       
        Destroy(k); 

    }


    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        base.OnSelectEntered(args);

        KeyDie();

    }
}

