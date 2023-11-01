using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public Transform canvas1;
    public Transform canvas2;
    // Start is called before the first frame update

    public void ViewControls()
    {
        canvas1.gameObject.SetActive(false);
        canvas2.gameObject.SetActive(true);
    }
}

