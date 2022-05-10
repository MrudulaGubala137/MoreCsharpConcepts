using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ChangeCubeColorUsingDE.onActionButtonClick += ToFallDown;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ToFallDown()
    {
        GetComponent<Rigidbody>().useGravity = true;
    }
}
// Create a program using delegates and events where you hit the space key I want to change cube position
// to 5,5,5. The cube script need to subscribe the event and invoke when you hit the space key. 