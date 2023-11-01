using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightDoor : MonoBehaviour
{
    public Transform door;

    DooROPenner dooROPenner;
    key key;
    // Start is called before the first frame update
    void Start()
    {
        dooROPenner = FindObjectOfType<DooROPenner>();
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
                if(!dooROPenner.dooropened)
                {
                    door.GetComponent<Outline>().enabled = true;
                }
                
            }
        }
    }
}
