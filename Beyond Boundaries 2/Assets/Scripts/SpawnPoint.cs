using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    private Basket basket;
    [SerializeField] private int scene;

    // Start is called before the first frame update
    void Awake()
    {
        basket = FindObjectOfType<Basket>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (basket.isFull)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(scene);
        }
    }
}
