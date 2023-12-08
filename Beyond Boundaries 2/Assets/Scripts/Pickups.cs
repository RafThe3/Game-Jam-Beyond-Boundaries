using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickups : MonoBehaviour
{
    [Header("SFX")]
    [SerializeField] private AudioClip pickupSFX;
    [SerializeField] private AudioClip dropoffSFX;
    [SerializeField] private AudioSource audioSource;

    [Header("Text")]
    [SerializeField] private TMPro.TextMeshProUGUI remainingItemsText;

    //Internal Variables
    private Basket basket;
    private GameObject[] pickups;
    private int numPickups;

    private void Awake()
    {
        basket = FindObjectOfType<Basket>();
    }

    private void Update()
    {
        UpdateText();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Pickups"))
        {
            AddPickup(collision);
        }

        if (collision.gameObject.CompareTag("Basket"))
        {
            DropoffItems();
        }
    }

    private void DropoffItems()
    {
        basket.items += numPickups;
        if (numPickups > 0)
        {
            audioSource.PlayOneShot(dropoffSFX);
        }
        numPickups = 0;
    }

    private void UpdateText()
    {
        pickups = GameObject.FindGameObjectsWithTag("Pickups");
        remainingItemsText.text = $"Remaining Items: {pickups.Length}";
        Debug.Log($"Pickups = {numPickups}");
    }

    private void AddPickup(Collider2D collision)
    {
        numPickups++;
        audioSource.PlayOneShot(pickupSFX);
        Destroy(collision.gameObject);
    }
}
