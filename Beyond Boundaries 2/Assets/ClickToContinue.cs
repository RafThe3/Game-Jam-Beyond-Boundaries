using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClickToContinue : MonoBehaviour
{
    private float timer;
    [SerializeField] private int day = 1;
    [SerializeField] private TextMeshProUGUI dayText;
    private Player player;

    // Start is called before the first frame update
    void Start()
    {
        dayText.text = $"Day {day}";
        player = FindObjectOfType<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        gameObject.SetActive(timer < 3);
        player.canMove = timer >= 3;
    }
}
