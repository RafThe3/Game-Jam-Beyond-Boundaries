using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LoadingScreen : MonoBehaviour
{
    [Min(1) ,SerializeField] private int day = 1;
    [SerializeField] private TextMeshProUGUI dayText;
    [SerializeField] private UnityEngine.UI.Image image;

    //Internal Variables
    private Player player;
    private float timer;

    private void Awake()
    {
        image.enabled = true;
    }

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
        image.enabled = timer < 3;
        dayText.enabled = timer < 3;
        player.canMove = timer >= 3;
    }
}
