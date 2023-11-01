using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mooing : MonoBehaviour
{
    AudioSource ad;
    // Start is called before the first frame update
    void Start()
    {
        ad = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(Mooing1());
        ad.Play();
    }

    IEnumerator Mooing1()
    {
        yield return new WaitForSeconds(3);
       
    }
}
