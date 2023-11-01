using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.SceneManagement;


public class UFring : XRGrabInteractable
{
    Animator ad;
    Animator ufo1;
    AudioSource remote;
    AudioSource ufoaudio;
    public Transform ufo;
    public Transform ufotransform;
    public AudioClip uforising;
    public AudioClip ufohover;
    public Transform cam;
    public Transform controller1;
    public Transform controller2;
    Animator camera;

    bool grabged = false;

    void Start()
    {
        remote = GetComponent<AudioSource>();
        ad = ufo.GetComponent<Animator>();
        ufo1 = ufotransform.GetComponent<Animator>();
        ufoaudio = ufotransform.GetComponent<AudioSource>();
        camera = cam.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }




  protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        base.OnSelectEntered(args);


        if (!grabged)
        {

            Destroy(controller1.gameObject);

            Destroy(controller2.gameObject);
            grabged = true;
            remote.Play();
            StartCoroutine(NextActions());

        }

        
        



        //ad.Play("UFOrising");


    }

    IEnumerator NextActions()
    {

        yield return new WaitForSeconds(8);
        ufotransform.gameObject.SetActive(true);
        ufo1.Play("ufoanimation");
        ufoaudio.Play();
        yield return new WaitForSeconds(5);
        ufoaudio.Stop();
        ufoaudio.clip = uforising;
        ufoaudio.Play();
        yield return new WaitForSeconds(12);
        ufoaudio.Stop();
        ufoaudio.clip = ufohover;
        ufoaudio.Play();
        yield return new WaitForSeconds(8);
        camera.Play("Closing");
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("GameEnd");

    }
}