using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TripWireDetect : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D Wire)
    { 
        if(Wire.gameObject.tag == "Player")
        {
            Debug.Log("triped");
          
        }
        
    }
}
