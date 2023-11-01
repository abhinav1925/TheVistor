using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tractor_Sound : MonoBehaviour
{
    AudioSource aa;
    public AudioClip engineStart;
    public AudioClip engineSound;
    // Start is called before the first frame update
    void Start()
    {
        aa = GetComponent<AudioSource>();
        aa.clip = engineStart;
        aa.PlayOneShot(aa.clip);
       
            aa.clip = engineSound;
            aa.Play();
            aa.loop = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
