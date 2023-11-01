using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{

    key key;
    Animator animator;
    public GameObject button;

    // Start is called before the first frame update
    void Start()
    {
        key = FindObjectOfType<key>();
        animator = GetComponent<Animator>();
       
    }

    // Update is called once per frame
    void Update()
    {
      
    }


    public void OpenDoor()
    {
        if (key.gotKey == true)
        {
            animator.Play("OpenDoor");
            Destroy(button);
        }
    }


}
