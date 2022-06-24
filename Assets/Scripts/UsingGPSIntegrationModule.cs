using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsingGPSIntegrationModule : MonoBehaviour
{
    GPSIntegrationModule myGPS;
    public GameObject Marker;
    public 
    // Start is called before the first frame update
    void Start()
    {
        myGPS = GameObject.FindObjectOfType<GPSIntegrationModule>();
        if(myGPS == null)
        {
            throw new System.Exception("ERROR:  Scene does not contain a GPSIntegrationModule Script.  Please add one!");
        }
        myGPS.OnGPSModuleStart += GPSStarted;
    }

    private void OnDestroy()
    {
        myGPS.OnGPSModuleStart -= GPSStarted;
    }

    public void GPSStarted()
    {
        myGPS.writeToScreenConsole("Receieved event, spawning objects!");
        myGPS.CreatObjectFromGPS(Marker, new Vector2(26.272373799283866f, -80.18122553728048f));
        myGPS.CreatObjectFromGPS(Marker, new Vector2(26.272395445511894f, -80.18127649924762f));
        myGPS.CreatObjectFromGPS(Marker, new Vector2(26.272436332820504f, -80.18123090169807f));
        GameObject temp = myGPS.CreatObjectFromGPS(Marker, new Vector2(26.272356963325944f, -80.18112093113739f));
        myGPS.writeToScreenConsole("Created closes marker at: " + temp.transform.position.ToString("F5"));
    }

    // Update is called once per frame
    void Update()
    {
        


    }

  
}
