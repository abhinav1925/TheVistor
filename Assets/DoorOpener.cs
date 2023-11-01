using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpener : MonoBehaviour
{
    key key;
    public GameObject cube;
    public GameObject cube1;
    // Start is called before the first frame update
    void Start()
    {
        key = FindObjectOfType<key>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "cube")
        {
            key.gotKey = true;
            Destroy(cube);
            Destroy(cube1);
        }
    }
}
