using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flicker : MonoBehaviour
{

    public bool isFlickering = false;
    public float timeDelay;
    bool Filckerafter = true;
    AudioSource ad;
    // Start is called before the first frame update
    void Start()
    {
        ad = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Filckerafter)
        {
            StartCoroutine(WaitforFlicker());
          
            if (!isFlickering)
            {
                StartCoroutine(FlickeringLight());
              
            }
           

        }

        else
        {
            StartCoroutine(WaitforStopFlicker());
        }
        

    }

    IEnumerator FlickeringLight()
    {

        isFlickering = true;
        ad.Play();
        this.gameObject.GetComponent<Light>().enabled = false;
        timeDelay = Random.Range(0.01f, 0.9f);
        yield return new WaitForSeconds(timeDelay);
        this.gameObject.GetComponent<Light>().enabled = true;
        timeDelay = Random.Range(0.01f, 0.9f);
        yield return new WaitForSeconds(timeDelay);
        isFlickering = false;
        ad.Stop();

    }

    IEnumerator WaitforFlicker()
    {
        
        yield return new WaitForSeconds(5f);
        Filckerafter = false;
      


    }

    IEnumerator WaitforStopFlicker()
    {
       
        yield return new WaitForSeconds(5f);
        Filckerafter = true;
      
    }

}
