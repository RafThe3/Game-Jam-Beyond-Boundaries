using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour
{
    [SerializeField] private int requiredAmount;
    [HideInInspector] public int items;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (items == requiredAmount)
        {
            Debug.Log("DaBaby");
        }
    }
}
