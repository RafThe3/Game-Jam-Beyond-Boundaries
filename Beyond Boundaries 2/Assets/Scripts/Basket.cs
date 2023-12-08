using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour
{
    private int requiredAmount;
    [HideInInspector] public int items;
    [HideInInspector] public bool isFull;
    [SerializeField] private TMPro.TextMeshProUGUI objectiveText;

    // Start is called before the first frame update
    void Start()
    {
        requiredAmount = GameObject.FindGameObjectsWithTag("Pickups").Length;
    }

    // Update is called once per frame
    void Update()
    {
        if (items == requiredAmount)
        {
            objectiveText.text = "Objective: Go home";
            isFull = true;
            Debug.Log("Basket is full");
        }
    }
}
