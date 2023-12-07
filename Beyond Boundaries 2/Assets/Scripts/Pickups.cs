using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickups : MonoBehaviour
{
    private int numPickups;

    private void Update()
    {
        Debug.Log(numPickups);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Pickups"))
        {
            numPickups++;
            Destroy(collision.gameObject);
        }
    }
}
