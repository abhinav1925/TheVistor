using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightDoor1 : MonoBehaviour
{
    public Transform door;


    key key;
    // Start is called before the first frame update
    void Start()
    {
       
        key = FindObjectOfType<key>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "test")
        {
            if(key.gotKey)
            {
                
                
                    door.GetComponent<Outline>().enabled = true;
                
                
            }
        }
    }
}
