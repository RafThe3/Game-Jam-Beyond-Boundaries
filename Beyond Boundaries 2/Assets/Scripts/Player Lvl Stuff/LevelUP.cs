using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LevelUP : MonoBehaviour
{
   
    void OnTriggerEnter2D(Collider2D collision)
    {
       if (collision.gameObject.tag == "Player")
       {
            Destroy(gameObject);
       }
    }
}
