using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chewing : MonoBehaviour
{

    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.Play("idle");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
