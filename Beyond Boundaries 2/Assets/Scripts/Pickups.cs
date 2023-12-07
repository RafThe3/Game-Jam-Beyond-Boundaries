using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickups : MonoBehaviour
{
    [SerializeField] private AudioClip pickupSFX;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private TMPro.TextMeshProUGUI remainingItemsText;

    //Internal Variables
    private GameObject[] pickups;
    private int numPickups;

    private void Update()
    {

        Debug.Log($"Pickups = {numPickups}");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Pickups"))
        {
            AddPickup(collision);
        }
    }

    private void AddPickup(Collider2D collision)
    {
        numPickups++;
        audioSource.PlayOneShot(pickupSFX);
        Destroy(collision.gameObject);
    }
}
