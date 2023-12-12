using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LvlProgress : MonoBehaviour
{
    [SerializeField] int levelProgress = 0;
    [SerializeField] TextMeshProUGUI myText;
    [SerializeField] float expBoost;
    public float x;
    private float y;
    [SerializeField] float i; 
    

    void Start()
    {
        //y = Player.moveSpeed;

    }

    void OnTriggerEnter2D(Collider2D LvlCollided)
    {
        if (LvlCollided.gameObject.tag == "LvlDrops")
        {
            i++;
            levelProgress++;
            myText.text = "Exp:" + levelProgress + "/10";

            Debug.Log(message: x = (float)(y + 0.20 * i));
            Debug.Log(message: x = (float)(5 + 0.20 * i));
        }
       
    }
}
