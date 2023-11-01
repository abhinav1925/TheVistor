using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BlinkPoint : MonoBehaviour
{

   public Transform Dart;
    public Transform Heart;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "tractor")
        {
            Dart.GetComponent<AudioSource>().Play();
            Heart.GetComponent<AudioSource>().Play();
        }
          
    }


}
