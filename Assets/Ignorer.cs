using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ignorer : MonoBehaviour
{

    public Transform g1;
    public Transform g2;
    public Transform g3;
    public Transform g4;
    public Transform g5;
    public Transform g6;
    public Transform g7;
    public Transform g8;
    public Transform g9;
    public Transform g10;
    public Transform g11;
    public Transform g12;
    public Transform g13;
    public Transform g14;
    public Transform g15;
    public Transform g16;
    public Transform g17;
    public Transform g18;
    public Transform g19;
    public Transform g20;
    public Transform g21;
    public Transform g22;
    public Transform g23;
    public Transform g24;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Physics.IgnoreCollision(g1.GetComponent<Collider>(), GetComponent<Collider>());
        Physics.IgnoreCollision(g2.GetComponent<Collider>(), GetComponent<Collider>());
        Physics.IgnoreCollision(g3.GetComponent<Collider>(), GetComponent<Collider>());
        Physics.IgnoreCollision(g4.GetComponent<Collider>(), GetComponent<Collider>());
        Physics.IgnoreCollision(g5.GetComponent<Collider>(), GetComponent<Collider>());
        Physics.IgnoreCollision(g6.GetComponent<Collider>(), GetComponent<Collider>());
        Physics.IgnoreCollision(g7.GetComponent<Collider>(), GetComponent<Collider>());
        Physics.IgnoreCollision(g8.GetComponent<Collider>(), GetComponent<Collider>());
        Physics.IgnoreCollision(g9.GetComponent<Collider>(), GetComponent<Collider>());
        Physics.IgnoreCollision(g10.GetComponent<Collider>(), GetComponent<Collider>());
        Physics.IgnoreCollision(g11.GetComponent<Collider>(), GetComponent<Collider>());
        Physics.IgnoreCollision(g12.GetComponent<Collider>(), GetComponent<Collider>());
        Physics.IgnoreCollision(g13.GetComponent<Collider>(), GetComponent<Collider>());
        Physics.IgnoreCollision(g14.GetComponent<Collider>(), GetComponent<Collider>());
        Physics.IgnoreCollision(g15.GetComponent<Collider>(), GetComponent<Collider>());
        Physics.IgnoreCollision(g16.GetComponent<Collider>(), GetComponent<Collider>());
        Physics.IgnoreCollision(g17.GetComponent<Collider>(), GetComponent<Collider>());
        Physics.IgnoreCollision(g18.GetComponent<Collider>(), GetComponent<Collider>());
        Physics.IgnoreCollision(g19.GetComponent<Collider>(), GetComponent<Collider>());
        Physics.IgnoreCollision(g20.GetComponent<Collider>(), GetComponent<Collider>());
        Physics.IgnoreCollision(g21.GetComponent<Collider>(), GetComponent<Collider>());
        Physics.IgnoreCollision(g22.GetComponent<Collider>(), GetComponent<Collider>());
        Physics.IgnoreCollision(g23.GetComponent<Collider>(), GetComponent<Collider>());
        Physics.IgnoreCollision(g24.GetComponent<Collider>(), GetComponent<Collider>());
   
    }

    private void OnCollisionEnter(Collision collision)
    {
     
    }


    
}
