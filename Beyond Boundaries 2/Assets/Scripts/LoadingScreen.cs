using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LoadingScreen : MonoBehaviour
{
    [Tooltip("The current day number."), Min(1) ,SerializeField] private int day = 1;
    [SerializeField] private TextMeshProUGUI dayText;
    [SerializeField] private Canvas loadingScreen, playerUI;

    //Internal Variables
    private Player player;
    private float timer;

    // Start is called before the first frame update
    private void Start()
    {
        dayText.text = $"Day {day}";
        player = FindObjectOfType<Player>();
    }

    // Update is called once per frame
    private void Update()
    {
        WaitToPlay();
    }

    private void WaitToPlay()
    {
        timer += Time.deltaTime;
        loadingScreen.enabled = timer < 3;
        player.canMove = timer >= 3;
        playerUI.enabled = timer >= 3;
    }
}
