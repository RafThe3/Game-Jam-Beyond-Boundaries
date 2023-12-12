using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LvlProgress : MonoBehaviour
{
    [SerializeField] int levelProgress = 0;
    [SerializeField] TextMeshProUGUI myText;
    [SerializeField] float expBoost;
    private bool levelIncreased;
    public float x;
    [SerializeField] float i;

    private void Start()
    {
        levelIncreased = false;
    }

    void OnTriggerEnter2D(Collider2D LvlCollided)
    {
        if (LvlCollided.gameObject.tag == "LvlDrops")
        {
            i++;
            levelProgress++;
            myText.text = "Exp:" + levelProgress + "/10";
            levelIncreased = true;
            if (levelIncreased == true)
            {
                Debug.Log(message: x = (float)(5 + 0.20 * i));
            }
        }
        else
        {
            levelIncreased = false;
        }
    }
}
