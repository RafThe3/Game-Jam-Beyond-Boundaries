using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour
{
    [SerializeField] private TMPro.TextMeshProUGUI objectiveText;

    //Internal Variables
    [HideInInspector] public int items;
    [HideInInspector] public bool isFull;
    private int requiredAmount;

    private void Start()
    {
        requiredAmount = GameObject.FindGameObjectsWithTag("Pickups").Length;
    }

    private void Update()
    {
        isFull = items == requiredAmount;
    }
}
