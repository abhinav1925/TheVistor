using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorPush : MonoBehaviour
{
    public Transform door;
    key key;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = door.GetComponent<Animator>();
        key = FindObjectOfType<key>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "door")
        {
            if (key.gotKey)
            {
                
                animator.Play("OpenDoor");
            }
        }
    }
}
