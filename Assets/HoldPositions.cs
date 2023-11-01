using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoldPositions : MonoBehaviour
{
    Transform currentLocation1;
    Transform currentLocation2;
    public Transform ladder;
    public Transform ladder2;

    //public GameObject button;
    void Start()
    {
        currentLocation1.position = ladder.position;
        currentLocation1.rotation = ladder.rotation;
        currentLocation2.position = ladder2.position;
        currentLocation2.rotation = ladder2.rotation;


    }

    // Update is called once per frame
    void Update()
    {
        ladder.transform.position = currentLocation1.transform.position;
        ladder.transform.rotation = currentLocation1.transform.rotation;

        ladder2.transform.position = currentLocation2.transform.position;
        ladder2.transform.rotation = currentLocation2.transform.rotation;
    }

}
