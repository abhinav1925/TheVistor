using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CowAnimation : MonoBehaviour
{
    public bool startCowActions = false;
    public Transform cow;
    public float rotateSpeed = 3.0f;
    bool onRotation = false;
    Quaternion qr1 = Quaternion.Euler(0f, 105f, 0f);
    Quaternion qr2 = Quaternion.Euler(0f, 100f, 0f);
    Quaternion qr3 = Quaternion.Euler(0f, 1f, 0f);
    Quaternion qr4 = Quaternion.Euler(0f, 10f, 0f);
    public Transform cow2postion;
    public Transform cow3postion;
    public Transform cow4postion;
    public float moveSpeed;
    public bool time1updated = false;
    float startTime;
    float journeyLength;
    public bool moveStart = false;
    public bool moveStart1 = false;
    public bool completeFirstRotation = false;
    public bool completeSecondRotation = false;
    Animator ar;
    AudioSource aa;
    Vector3 cow2pos;
    // Start is called before the first frame update
    void Start()
    {
        cow2pos = cow2postion.position;
        ar = cow.GetComponent<Animator>();
        aa = cow.GetComponent<AudioSource>();
       
    }

    // Update is called once per frame
    void Update()
    {

       if(startCowActions)
        {
            ar.Play("walk");
            cowActions();
        }
       
           
           
             
        


    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "test")
        {
            Debug.Log("Action!");

            startCowActions = true;
        }
    }

    void updateTimeAndLength()
    {
        startTime = Time.time;
        journeyLength = Vector3.Distance(cow.transform.position, cow2pos);
        time1updated = true;
    }

    void cowActions()
    {
        aa.Stop();

        if(!completeFirstRotation)
        {
            cow.rotation = Quaternion.Lerp(cow.rotation, qr1, Time.deltaTime * rotateSpeed);
            StartCoroutine(moveFirst());
           
        }
        

       
        if (moveStart)
        {
           
            if (!time1updated)
            {
                updateTimeAndLength();
            }

            float distCovered = (Time.time - startTime) * moveSpeed;

            float fractionOfJourney = distCovered / journeyLength;
            cow.transform.position = Vector3.Lerp(cow.transform.position, cow2pos, fractionOfJourney);
            StartCoroutine(rotate1Start());
            

        }

    

        if (completeSecondRotation)
        {
            cow.rotation = Quaternion.Lerp(cow.rotation, qr3, Time.deltaTime * rotateSpeed);
            StartCoroutine(moveSecond());
            

        }

     

        if(moveStart1)
        {
           
            if (!time1updated)
            {
                updateTimeAndLength();
            }

            float distCovered = Time.deltaTime * moveSpeed;

            float fractionOfJourney = distCovered / journeyLength;
            cow.transform.position = Vector3.Lerp(cow.transform.position, cow4postion.position, Time.deltaTime * 0.5f);
            StartCoroutine(rotate2Start());
      


        }


    }

    IEnumerator moveFirst()
    {
        yield return new WaitForSeconds(4);
       
        moveStart = true;
        completeFirstRotation = true;
    }

    IEnumerator rotate1Start()
    {
        yield return new WaitForSeconds(15);
        moveStart = false;
        time1updated = false;
        completeSecondRotation = true;
       
    }

    IEnumerator moveSecond()
    {
        yield return new WaitForSeconds(3);
        completeSecondRotation = false;
        moveStart1 = true;
    }



    IEnumerator rotate2Start()
    {
        yield return new WaitForSeconds(3);
        ExitCow();
    }


    void ExitCow()
    {
        startCowActions = false;
        ar.enabled = false;
        ar.enabled = true;
        ar.Play("idle");
        Destroy(this.gameObject);

    }
}
