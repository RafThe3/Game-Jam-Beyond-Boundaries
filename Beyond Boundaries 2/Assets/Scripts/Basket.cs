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
            isFull = true;
            objectiveText.text = "Objective: Go home";
        }
    }
}
