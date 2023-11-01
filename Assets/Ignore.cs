using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ignore : MonoBehaviour
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


    CharacterController cr;

    // Start is called before the first frame update
    void Start()
    {
        cr = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Physics.IgnoreCollision(cr, g1.GetComponent<Collider>());
        Physics.IgnoreCollision(cr, g2.GetComponent<Collider>());
        Physics.IgnoreCollision(cr, g3.GetComponent<Collider>());
        Physics.IgnoreCollision(cr, g4.GetComponent<Collider>());
        Physics.IgnoreCollision(cr, g5.GetComponent<Collider>());
        Physics.IgnoreCollision(cr, g6.GetComponent<Collider>());
        Physics.IgnoreCollision(cr, g7.GetComponent<Collider>());
        Physics.IgnoreCollision(cr, g8.GetComponent<Collider>());
        Physics.IgnoreCollision(cr, g9.GetComponent<Collider>());
        Physics.IgnoreCollision(cr, g10.GetComponent<Collider>());
        Physics.IgnoreCollision(cr, g11.GetComponent<Collider>());
        Physics.IgnoreCollision(cr, g12.GetComponent<Collider>());
        Physics.IgnoreCollision(cr, g13.GetComponent<Collider>());
        Physics.IgnoreCollision(cr, g14.GetComponent<Collider>());
        Physics.IgnoreCollision(cr, g15.GetComponent<Collider>());
        Physics.IgnoreCollision(cr, g16.GetComponent<Collider>());
        Physics.IgnoreCollision(cr, g17.GetComponent<Collider>());
        Physics.IgnoreCollision(cr, g18.GetComponent<Collider>());
    }

    
}
