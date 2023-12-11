using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LvlProgress : MonoBehaviour
{
    [SerializeField] int levelProgress = 0;
    [SerializeField] TextMeshProUGUI myText;

    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D LvlCollided)
    {
        if (LvlCollided.gameObject.tag == "LvlDrops")
        {
            levelProgress++;
            myText.text = "Level:" + levelProgress;
        }
    }
}
