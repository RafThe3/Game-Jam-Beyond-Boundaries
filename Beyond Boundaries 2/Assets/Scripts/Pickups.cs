using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickups : MonoBehaviour
{
    [Header("General")]
    [Min(0), SerializeField] private int maxItemsInHand = 5;

    [Header("SFX")]
    [SerializeField] private AudioClip pickupSFX;
    [SerializeField] private AudioClip dropoffSFX;
    [SerializeField] private AudioSource audioSource;

    [Header("Text")]
    [SerializeField] private TMPro.TextMeshProUGUI itemsInHandText;
    [SerializeField] private TMPro.TextMeshProUGUI objectiveText;
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
        pickups = GameObject.FindGameObjectsWithTag("Pickups");
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
        remainingItemsText.text = $"Remaining Strawberries: {pickups.Length}";
        itemsInHandText.text = numPickups == maxItemsInHand ? "Strawberries In Hand: FULL" : $"Strawberries In Hand: {numPickups}";
        objectiveText.text = numPickups == maxItemsInHand ? "Objective: Drop Off Strawberries Into Basket"
            : basket.isFull ? "Objective: Go Home"
            : "Objective: Find & Collect Strawberries";
    }

    private void AddPickup(Collider2D collision)
    {
        if (numPickups != maxItemsInHand)
        {
            numPickups++;
            audioSource.PlayOneShot(pickupSFX);
            Destroy(collision.gameObject);
        }
    }
}
